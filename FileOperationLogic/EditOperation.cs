using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperationLogic
{
    public class EditOperation
    {
        public Stack<string> undo;
        public bool enableEditText=true;

        public EditOperation()
        {
            undo = new Stack<string>();
        }

        public void stackClear()
        {
            undo.Clear();
        }

        public void addItemToStack(string item)
        {
            if (undo.Count == 0)
            {
                undo.Push(" ");
            }
            undo.Push(item);
        }

        public string removeItemFromStack()
        {
            enableEditText = false;
            return undo.Pop();
        }

        public bool canUndo()
        {
            return undo.Count > 0 ? true : false;
        }
    }
}
