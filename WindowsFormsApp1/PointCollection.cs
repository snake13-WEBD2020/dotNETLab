using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;

namespace WindowsFormsApp1
{
    [Serializable]
    class PointCollection : CollectionBase
    {

        public Point Add()
        {
            Point Item = new Point();
            List.Add(Item);
            return Item;
        }
        public Point Add(Point Item)
        {
            List.Add(Item);
            return Item;
        }

        public void Insert(int Index, Point Item)
        {
            List.Insert(Index, Item);
        }
        public void Remove(Point Item)
        {
            List.Remove(Item);
        }
        public Point this[int Intex]
        {
            get
            {
                return (Point)List[Intex];
            }
        }

        public void Save()
        {
            SaveFileDialog svfDialog = new SaveFileDialog();
            svfDialog.Filter = "Point file (*.pf)|*.pf";
            svfDialog.DefaultExt = "pf";
            if (svfDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fStream = null;
                SoapFormatter mySoapFormatter = new SoapFormatter();

                try
                {
                    fStream = new FileStream(svfDialog.FileName,
                                    FileMode.Create, FileAccess.Write);
                    mySoapFormatter.Serialize(fStream, this);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    if (fStream != null) fStream.Close();
                }
            }

        }
        
        public void SaveXml()
        {
            SaveFileDialog svfDialog = new SaveFileDialog();
            svfDialog.Filter = "Point file (*.xml)|*.xml";
            svfDialog.DefaultExt = "xml";
            if (svfDialog.ShowDialog() == DialogResult.OK)
            {
                
                FileStream fStream = null;
                //Collection progData = new Collection { DataString = "Test1" };
                Point3D progData = new Point3D();

                XmlSerializer myXmlFormatter = new XmlSerializer(typeof(Point3D));

                try
                {
                    fStream = new FileStream(svfDialog.FileName,
                                    FileMode.Create, FileAccess.Write);
                    myXmlFormatter.Serialize(fStream, progData);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    if (fStream != null) fStream.Close();
                }
            }
            //
        }

    }
    }
        
