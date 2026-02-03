namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Bro Code";
            Console.WriteLine(fullName);
            String phoneNumber = "123-456-7890";
            Console.WriteLine(phoneNumber);
            String fullNameUp = fullName.ToUpper();
            Console.WriteLine(fullNameUp);
            String fullNameLow = fullName.ToLower();
            Console.WriteLine(fullNameLow);
            String phoneNumberNormal = phoneNumber.Replace("-","");
            Console.WriteLine(phoneNumberNormal);
            String UserName = fullName.Insert(0,"Mr.");
            Console.WriteLine(UserName);
            int nameLength = fullName.Length;
            Console.WriteLine(nameLength);

            String firstName = fullName.Substring(0, 3);
            String lastName = fullName.Substring(4, 4);



            Console.ReadKey();
        }
    }
}