using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Form = System.Windows.Forms.Form;

namespace RotateElement_V2
{
    public partial class Window_Form : Form
    {
        private UIDocument uidoc;
        private Document doc;
        private double Rotate;
        RevitEvent revitEvent = new RevitEvent();
        public Element Element;

        public Window_Form(UIDocument uidoc)
        {
            InitializeComponent();
            this.Rotate = Convert.ToDouble(Angle.Text);
            this.uidoc = uidoc;
            this.doc = uidoc.Document;
        }

        private void TextBox_Angle_TextChanged(object sender, EventArgs e)
        {
            this.Rotate = Convert.ToDouble(Angle.Text);
        }

        private void but_left_Click(object sender, EventArgs e)
        {

            revitEvent.Run(() => Excute(Rotate), true, doc, "", false);
        }

        private void but_right_Click(object sender, EventArgs e)
        {
            revitEvent.Run(() => Excute(-Rotate), true, doc, "", false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        void Excute(double angle)
        {
            try
            {
                using (Transaction tran = new Transaction(doc) )
                {
                    tran.Start("Rotate");
                    ICollection<ElementId> elementIds = uidoc.Selection.GetElementIds();
                    
                    if (Element==null)
                    {
                        Reference reference = uidoc.Selection.PickObject(ObjectType.Element);
                        Element = doc.GetElement(reference);
                    }

                    if (elementIds.Count==0)
                    {
                        MessageBox.Show("Select Element want rotate and continute","Info",MessageBoxButtons.OK);
                        IList<Reference> r = uidoc.Selection.PickObjects(ObjectType.Element);
                        foreach (Reference reference in r)
                        {
                            elementIds.Add(reference.ElementId);
                        }

                    }
                    Line axis = (Element.Location as LocationCurve)?.Curve as Line;
                    double AngleConvert = angle * Math.PI / 180;
                    ElementTransformUtils.RotateElements(uidoc.Document, elementIds, axis, AngleConvert);
                    uidoc.Selection.SetElementIds(elementIds);
                    tran.Commit();
                }
            }
            catch (Autodesk.Revit.Exceptions.OperationCanceledException) { }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


    }
}
