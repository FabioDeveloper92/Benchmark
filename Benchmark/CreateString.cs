
using System.Collections.Generic;
using System.Text;

namespace Benchmark
{
    public class CreateString
    {
        private readonly int _numItem;
        public CreateString(int numItem)
        {
            _numItem = numItem;
        }

        public string GenerateWithStringBuilder()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < _numItem; i++)
            {
                sb.Append("Hello World!" + i);
            }

            return sb.ToString();
        } 
        
        public string GenerateWithList()
        {
            var list = new List<string>(_numItem);
            for (int i = 0; i < _numItem; i++)
            {
                list.Add("Hello World!" + i);
            }

            return list.ToString();
        }
    }
}
