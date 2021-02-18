using System.Linq;
using System.Collections.Generic;
namespace TriTreeData.console.Structures
{
    public class Node
    {

        public Node(char name)
        {
            _name = name;
            _children = new Dictionary<char, Node>();
        }

        private char _name;

        private string _value { get ; set;}

        private Dictionary<char, Node> _children;

        public void Insert(string key, string value)
        {
            if(string.IsNullOrEmpty(key))
            {
                _value = value;
                System.Console.WriteLine($"saved {_value} in {_name}");
                return;
            }
            var startChar = key.ToCharArray().First();
            
            var premorseText = key.Substring(1);
    
            var findResult = _children.TryGetValue(startChar, out var nextNode);
            if(findResult)
            {
                nextNode.Insert(premorseText, value);
                return;
            }
            var newNode = AddNewNode(startChar);
            newNode.Insert(premorseText, value);
        }


        private Node AddNewNode(char name)
        {
            var newNode = new Node(name);
            _children.Add(name, newNode);
            System.Console.WriteLine($"new Node: {name}");
            return newNode;
        }

        public string Search(string text)
        {
            System.Console.WriteLine($"search text = {text}, node name = {_name}");
            
            
            if(string.IsNullOrEmpty(text))
            {
                if(string.IsNullOrEmpty(_value))
                    throw new System.Exception($"not found. naghes. name is {_name}");
                return _value;
            }

            var startChar = text.ToCharArray().First();
            
            var result = _children.TryGetValue(startChar, out var nextNode);
            
            if(result)
            {
                var premorseText = text.Substring(1);
                return nextNode.Search(premorseText);
            }
            //todo: fix this
            throw new System.Exception("not found");
        }
 
    }
}
