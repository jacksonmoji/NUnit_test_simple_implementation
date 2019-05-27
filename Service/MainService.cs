using System;

namespace Service.MainService
{
    public class MainService 
    {

        private int _input;
        
        public int UserInput{

            set{
                if (value > 5){
                    throw new OverflowException();// "The number you entered is is greater 5, please try again";
                }
            _input = value; 
            }

            get{
            return _input;
            }
        }
        public string numberDif(){
            int result = 0;
            try{
            result = 5 - this.UserInput;
            }catch (InvalidCastException e){
                Console.WriteLine(string.Format("The following type casting error was thrown :{0}", e));

            }catch (Exception e){
                Console.WriteLine(string.Format("The following error was thrown :{0}", e));
            }
            return string.Format("The number required to get to 5 is {0}", result); 
        }
    }
}
