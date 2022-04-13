using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _153Final
{
    class Cell
    {
        int row;
        int col;
        Button btn;

        public Cell()
        {

        }

        public Cell(int r, int c, Button button)
        {
            row = r;
            col = c;
            btn = button;
        }

        public int getRow()
        {
            return row;
        }
        public int getCol()
        {
            return col;
        }
        public Button getButton()
        {
            return btn;
        }

        public void setRow(int r)
        {
            row = r;
        }

        public void setCol(int c)
        {
            col = c;
        }

        public void setBtn(Button b)
        {
            btn = b;
        }
    }
}
