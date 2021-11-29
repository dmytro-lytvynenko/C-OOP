using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_lab2
{
    class Archive
    {
        public string Author = null;
        public string Material = null;
        public string Faculty = null;
        public string Cathedry = null;
        public string Material_Type = null;
        public string Pages = null;
        public string Date = null;

        public Archive() { }

        public Archive(string[] data)
        {
            Author = data[0];
            Material = data[1];
            Faculty = data[2];
            Cathedry = data[3];
            Material_Type = data[4];
            Pages = data[5];
            Date = data[6];
        }
        public Archive(IStrategy algo)
        {
            Author = String.Empty;
            Material = String.Empty;
            Faculty = String.Empty;
            Cathedry = String.Empty;
            Material_Type = String.Empty;
            Pages = String.Empty;
            Date = String.Empty;
        }
        public bool Comparing(Archive work)
        {
            if ((this.Author == work.Author) &&
                (this.Material == work.Material) &&
                (this.Faculty == work.Faculty) &&
                (this.Cathedry == work.Cathedry) &&
                (this.Material_Type == work.Material_Type) &&
                (this.Pages == work.Pages) &&
                (this.Date == work.Date))
                return true;
            else return false;
        }
        public IStrategy Algo { get; set; }
        public List<Archive> Algorithm(Archive work, string path)
        {
            return Algo.Algorithm(work, path);
        }
    }
}