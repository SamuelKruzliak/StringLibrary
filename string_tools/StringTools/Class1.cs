
namespace StringTools
{
    public class ArrayLib
    {
        static public bool Contains(int[] array, int a){
            foreach(int item in array){
                if(item == a){
                    return true;
                }
            }

            return false;
        }
        static public bool Contains(string[] array, string a){
            foreach(string item in array){
                if(item == a){
                    return true;
                }
            }

            return false;
        }
        static public bool Contains(char[] array, char a){
            foreach(char item in array){
                if(item == a){
                    return true;
                }
            }

            return false;
        }
        static public bool Contains(double[] array, double a){
            foreach(double item in array){
                if(item == a){
                    return true;
                }
            }

            return false;
        }

    }
}
