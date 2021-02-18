
namespace TriTreeData.console.Structures
{
    public class TriTree
    {
        
        public TriTree()
        {
            _root = new Node(' ');
        }

        private Node _root;


        public void Add(string text)
        {
            _root.Insert(text, text);
        }

        public string Search(string text)
        {
            return _root.Search(text);
        }
    }
}
