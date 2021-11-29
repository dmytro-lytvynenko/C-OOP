using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOp_lab2
{
    class LINQ : IStrategy
    {
        List<Archive> info = new List<Archive>();
        XDocument doc = new XDocument();
        public LINQ(string path)
        {
            doc = XDocument.Load(path);
        }

        public List<Archive> Algorithm(Archive work, string path)
        {
            List<XElement> match = (from val in doc.Descendants("masterpiece")
                                    where
                                    ((work.Author == null || work.Author == val.Parent.Attribute("AUTHOR").Value) &&
                                    (work.Material == null || work.Material == val.Attribute("MATERIAL").Value) &&
                                    (work.Faculty == null || work.Faculty == val.Attribute("FACULTY").Value) &&
                                    (work.Cathedry == null || work.Cathedry == val.Attribute("CATHEDRY").Value) &&
                                    (work.Material_Type == null || work.Material_Type == val.Attribute("MATERIAL_TYPE").Value) &&
                                    (work.Pages == null || work.Pages == val.Attribute("PAGES").Value) &&
                                    (work.Date == null || work.Date == val.Attribute("DATE").Value))
                                    select val).ToList();
            foreach (XElement obj in match)
            {
                Archive work1 = new Archive();
                work1.Author = obj.Parent.Attribute("AUTHOR").Value;
                work1.Material = obj.Attribute("MATERIAL").Value;
                work1.Faculty = obj.Attribute("FACULTY").Value;
                work1.Cathedry = obj.Attribute("CATHEDRY").Value;
                work1.Material_Type = obj.Attribute("MATERIAL_TYPE").Value;
                work1.Pages = obj.Attribute("PAGES").Value;
                work1.Date = obj.Attribute("DATE").Value;
                info.Add(work1);
            }
            return info;
        }
    }
}
