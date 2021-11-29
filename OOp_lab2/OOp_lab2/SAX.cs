using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OOp_lab2
{
    class SAX : IStrategy
    {
        private List<Archive> info = new List<Archive>();
        XmlDocument doc = new XmlDocument();
        public SAX(string path)
        {
            doc.Load(path);
        }

        public List<Archive> Algorithm(Archive work, string path)
        {
            info.Clear();
            XmlReader BestReader = XmlReader.Create(path);
            List<Archive> result = new List<Archive>();
            Archive archive = null;
            string _author = "aboba";

            while (BestReader.Read())
            {
                if (BestReader.Name == "author")
                {
                    while (BestReader.MoveToNextAttribute())
                    {
                        if (BestReader.Name == "AUTHOR")
                        {
                            _author = BestReader.Value;
                        }
                    }
                }
                if (BestReader.Name == "masterpiece")
                {
                    archive = new Archive();
                    archive.Author = _author;

                    if (BestReader.HasAttributes)
                    {
                        while (BestReader.MoveToNextAttribute())
                        {
                            if (BestReader.Name == "MATERIAL")
                            {
                                archive.Material = BestReader.Value;
                            }
                            if (BestReader.Name == "FACULTY")
                            {
                                archive.Faculty = BestReader.Value;
                            }
                            if (BestReader.Name == "CATHEDRY")
                            {
                                archive.Cathedry = BestReader.Value;
                            }
                            if (BestReader.Name == "MATERIAL_TYPE")
                            {
                                archive.Material_Type = BestReader.Value;
                            }
                            if (BestReader.Name == "PAGES")
                            {
                                archive.Pages = BestReader.Value;
                            }
                            if (BestReader.Name == "DATE")
                            {
                                archive.Date = BestReader.Value;
                            }
                        }
                    }
                    if (archive.Material != null)
                    {
                        result.Add(archive);
                    }
                }
            }
            info = Filtr(result, work);
            return info;
        }
        public List<Archive> Filtr(List<Archive> allCar, Archive param)
        {
            List<Archive> result = new List<Archive>();
            if (allCar != null)
            {
                foreach (Archive e in allCar)
                {
                    try
                    {
                        if (
                            (e.Author == param.Author || param.Author == null) &&
                            (e.Material == param.Material || param.Material == null) &&
                            (e.Faculty == param.Faculty || param.Faculty == null) &&
                            (e.Cathedry == param.Cathedry || param.Cathedry == null) &&
                            (e.Material_Type == param.Material_Type || param.Material_Type == null) &&
                            (e.Pages == param.Pages || param.Pages == null) &&
                            (e.Date == param.Date || param.Date == null)
                           )
                        {
                            result.Add(e);
                        }
                    }
                    catch { }
                }
            }
            return result;
        }
    }
}
