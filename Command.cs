#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System.Windows.Forms;
#endregion

namespace RotateElement_V2
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Autodesk.Revit.ApplicationServices.Application app = uiapp.Application;
            Document doc = uidoc.Document;

            ICollection<ElementId> elementIds = uidoc.Selection.GetElementIds();
            Reference reference = uidoc.Selection.PickObject(ObjectType.Element);
            Line axis = (doc.GetElement(reference).Location as LocationCurve).Curve as Line;

            command_class setting = new command_class();

            Window_Form window_Form = new Window_Form(setting);
            DialogResult dialogResult = window_Form.ShowDialog();
            double AngleConvert = setting.Angle * Math.PI / 180;

            MessageBox.Show(AngleConvert.ToString());

            using(Transaction t = new Transaction(doc,"Rorate Element"))
            {
                t.Start();
                ElementTransformUtils.RotateElements(doc, elementIds, axis, AngleConvert);
                t.Commit();
            }
            return Result.Succeeded;
        }
    }
    public class command_class
    {
        public double Angle { set; get; }
    }
}
