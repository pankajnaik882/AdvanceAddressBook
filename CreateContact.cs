using System.Reflection.Metadata.Ecma335;

namespace AddressBookSystem
{
    public class CreatContact
    {
        public string name;
        public void change(string[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.WriteLine("Enter the index Value to Delete : ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the name which you want to delete : ");
            string name = Console.ReadLine();
            if (n[index] == name)
            {
                n[index] = " ";
            }

            Console.Write("After Deleted Array :" +"");

            for (int j = 0; j < n.Length; j++)
            {
                if (n[j] == "")
                {
                    continue;
                }
                else
                {
                    Console.Write(n[j]+" ");
                }
            }
        }
    }
}