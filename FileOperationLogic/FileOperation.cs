using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FileOperationLogic
{
    public class FileOperation
    {
        private string filename;
        private bool isSave;
        private bool initialSave=false;
        private string fileLocation;


        public string Filename { get => filename; set => filename = value; }
        public bool IsSave { get => isSave; set => isSave = value; }
        public bool InitialSave { get => initialSave; set => initialSave = value; }
        public string FileLocation { get => fileLocation; set => fileLocation = value; }

        public void InitializeFile()
        {
            this.filename = "untitle.txt*";
            this.isSave = false;
        }

        public void setFileName(string file)
        {
            char[] sepatator = {'\\'};
            filename=file.Split(sepatator).Last();
        }

        public void savefile(string filename)
        { 
            FileLocation =filename;
            IsSave = true;
            setFileName(filename);
            
        }

      

    }
}
