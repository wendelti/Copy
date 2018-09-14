using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace copy
{
    public class CopierV1
    {

        public static void Copy()
        {

            int c;
            while ((c = Keyboard.Read()) != -1)
                Printer.Write(c);

        }

    }

    public class CopierV2
    {
        public static bool ptFlag = false;

        public static void Copy()
        {

            int c;
            while ((c = (ptFlag ? PaperTape.Read() : Keyboard.Read())) != -1)
                Printer.Write(c);

        }

    }


    public class CopierV3
    {
        public static bool ptFlag = false;
        public static bool punchFlag = false;

        public static void Copy()
        {

            int c;
            while ((c = (ptFlag ? PaperTape.Read() : Keyboard.Read())) != -1)
                if (punchFlag)
                    PaperTape.Punch(c);
                else
                    Printer.Write(c);

        }

    }


    public class CopierAgileVersion
    {

        public interface Reader
        {
            int Read();
        }

        public class KeyboardReader : Reader
        {
            public int Read() { return Keyboard.Read(); }
        }

        public static Reader reader = new KeyboardReader();

        public static void Copy()
        {
            int c;
            while ((c = reader.Read()) != -1)
                Printer.Write(c);

        }

    }
}
