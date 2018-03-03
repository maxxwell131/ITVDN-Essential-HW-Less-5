using System;

namespace Additional_Task
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] Eng = new string[5];
        private string[] Ukr = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; Eng[0] = "book"; Ukr[0] = "книга";
            key[1] = "ручка"; Eng[1] = "pen"; Ukr[1] = "ручка";
            key[2] = "солнце"; Eng[2] = "sun"; Ukr[2] = "сонце";
            key[3] = "яблоко"; Eng[3] = "apple"; Ukr[3] = "яблуко";
            key[4] = "стол"; Eng[4] = "table"; Ukr[4] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                string result= string.Format("{0} - нет перевода для этого слова.", index); ;
                for (int i = 0; i < key.Length; i++)
                {
                    if (index.Equals(key[i]))
                        result = key[i] + " - " + Eng[i] + " - " + Ukr[i];
                    else if (index.Equals(Eng[i]))
                        result = Eng[i] + " - " + key[i]  + " - " + Ukr[i];
                    else if (index.Equals(Ukr[i]))
                        result = Ukr[i] + " - " + Eng[i] + " - " + key[i] ;
                }
                return result;
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + Eng[index] + " - " + Ukr[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }     
    }
}
