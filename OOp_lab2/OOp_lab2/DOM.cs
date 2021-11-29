using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOp_lab2
{
    class DOM : IStrategy
    {
        XmlDocument doc = new XmlDocument();
        public DOM(string path)
        {
            doc.Load(path);
        }

        public List<Archive> Algorithm(Archive work, string path)
        {
            List<List<Archive>> info = new List<List<Archive>>();
            try
            {
                if (work.Author != null) info.Add(SearchByParam("author", "AUTHOR", work.Author, doc, 0));
                if (work.Material != null) info.Add(SearchByParam("masterpiece", "MATERIAL", work.Material, doc, 1));
                if (work.Faculty != null) info.Add(SearchByParam("masterpiece", "FACULTY", work.Faculty, doc, 1));
                if (work.Cathedry != null) info.Add(SearchByParam("masterpiece", "CATHEDRY", work.Cathedry, doc, 1));
                if (work.Material_Type != null) info.Add(SearchByParam("masterpiece", "MATHERIAL_TYPE", work.Material_Type, doc, 1));
                if (work.Pages != null) info.Add(SearchByParam("masterpiece", "PAGES", work.Pages, doc, 1));
                if (work.Date != null) info.Add(SearchByParam("masterpiece", "DATE", work.Date, doc, 1));
            }
            catch { }
            return Cross(info);
        }

        public static Archive Info(XmlNode node)
        {
            Archive nw = new Archive();
            nw.Author = node.ParentNode.Attributes.GetNamedItem("AUTHOR").Value;
            nw.Material = node.Attributes.GetNamedItem("MATERIAL").Value;
            nw.Faculty = node.Attributes.GetNamedItem("FACULTY").Value;
            nw.Cathedry = node.Attributes.GetNamedItem("CATHEDRY").Value;
            nw.Material_Type = node.Attributes.GetNamedItem("MATERIAL_TYPE").Value;
            nw.Pages = node.Attributes.GetNamedItem("PAGES").Value;
            nw.Date = node.Attributes.GetNamedItem("DATE").Value;
            return nw;
        }
        public static List<Archive> AllWorks(XmlDocument doc)
        {
            List<Archive> data2 = new List<Archive>();
            XmlNodeList elem = doc.SelectNodes("//Archive");
            try
            {
                foreach (XmlNode el in elem)
                {
                    data2.Add(Info(el));
                }
            }
            catch { }
            return data2;
        }
        public static List<Archive> SearchByParam(string nodename, string val, string param, XmlDocument doc, int n)
        {
            List<Archive> cars = new List<Archive>();
            if (param != String.Empty && param != null)
            {
                switch (n)
                {
                    case 0:
                        {
                            XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                            try
                            {
                                foreach (XmlNode e in elem)
                                {
                                    XmlNodeList list2 = e.ChildNodes;
                                    foreach (XmlNode ell in list2)
                                    {
                                        cars.Add(Info(ell));
                                    }
                                }
                            }
                            catch { }
                            return cars;
                        }
                    case 1:
                        {
                            XmlNodeList elem = doc.SelectNodes("//" + nodename + "[@" + val + "=\"" + param + "\"]");
                            try
                            {
                                foreach (XmlNode e in elem)
                                {
                                    cars.Add(Info(e));
                                }
                            }
                            catch { }
                            return cars;

                        }
                    default: break;
                }
            }
            return cars;
        }
        private static List<Archive> Cross(List<List<Archive>> list)
        {
            List<Archive> result = new List<Archive>();
            try
            {
                if (list != null)
                {
                    Archive[] Archive = list[0].ToArray();
                    if (Archive != null)
                    {
                        foreach (Archive elem in Archive)
                        {
                            bool IsIn = true;
                            foreach (List<Archive> t in list)
                            {
                                if (t.Count <= 0) return new List<Archive>();
                                foreach (Archive s in t)
                                {
                                    IsIn = false;
                                    if (elem.Comparing(s))
                                    {
                                        IsIn = true;
                                        break;
                                    }
                                }
                                if (!IsIn) break;
                            }
                            if (IsIn)
                            {
                                result.Add(elem);
                            }
                        }
                    }
                }
            }
            catch { }
            return result;
        }
    }
}
