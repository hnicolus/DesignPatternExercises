using System;
using System.Collections.Generic;
using System.Text;

namespace Drawer
{
    public class DrawObject
    {
        public virtual string Name { get; set; } = "Group";

        public string color { get; set; }
        private Lazy<List<DrawObject>> _children = new Lazy<List<DrawObject>>();

        public List<DrawObject> Children => _children.Value;


        private void Print(StringBuilder sb, int depth)
        {
            sb.Append(new String(' ', depth))
                .Append(string.IsNullOrWhiteSpace(color) ? string.Empty : $"{color}")
                .AppendLine(Name);

            foreach (var child in Children)
            {
                child.Print(sb, depth + 1);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            Print(sb, 0);
            return sb.ToString();
        }

    }
}
