namespace Learning
{
    public class PointerWithUnsafe
    {
        public void DemoUnsafe()
        {
            Reverse("Charulata");
        }

        private unsafe void Reverse(string input)
        {
            fixed (char* ptr = input)
            {
                char* start = ptr;
                char* end = ptr + input.Length - 1;

                while (start < end)
                {
                    char temp = *start;
                    *start = *end;
                    *end = temp;
                    start++;
                    end--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
