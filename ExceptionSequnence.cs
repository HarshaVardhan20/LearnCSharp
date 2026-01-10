using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public class ExceptionSequnence
    {
        public static void Main(string[] args)
        {
            int ans = 10;

            try
            {
				int x = 0;// no need to be in try block since there is no chance of error
                int m = Div(10, 0);
			}
            catch (DivideByZeroException ex)
            {
                throw new Exception("eRROR");
            }
            catch (ArithmeticException ex)
            {
                throw new Exception("Overflow eRROR");
            }
            
            catch (Exception ex)
			{

				throw;
			}
            //catch(SystemException ex)
            //{

            //}
            
            finally
			{
				ans = 0;
				// Clear memory

			}
        }

		public static int Div(int n, int m)
		{
			return n / m;
		}
    }
}
