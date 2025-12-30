namespace LearningCSharp
{
    public class Program
    {


        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //YoungProfessional yp = new YoungProfessional();

            //GeneralUses.GetRno();
            //GeneralUses.GetRno();

            //string sent = "I am Fine.";
            //int count = sent.WordCount();
            //Console.WriteLine(count);


            BigBoy bigBoy=new BigBoy();

            try
            {
                bigBoy.Names = new System.Collections.ArrayList();
                for (int i = 0; i < 10; i++)
                {
                    bigBoy.Names.Add(i.ToString());
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                bigBoy.Dispose();
            }
        }
    }


}
