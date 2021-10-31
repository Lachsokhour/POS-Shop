using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Shop.Models
{
    class FileUpload
    {
        protected string fileName;
        protected Image sourceFile;
        protected string pathFile;

        public FileUpload() { }
        public FileUpload(string fileName, Image sourceFile, string pathFile)
        {
            this.fileName = fileName;
            this.sourceFile = sourceFile;
            this.pathFile = pathFile;
        }

        public string Filename { get => this.fileName; set => this.fileName = value; }
        public Image SoureFile { get => this.sourceFile; set => this.sourceFile = value; }
        public string PathFile { get => this.pathFile; set => this.pathFile = value; }
    }
}
