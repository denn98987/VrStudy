using System.Windows;
using System.Windows.Controls;

namespace vrstud
{
    class Link : Label
    {
        public static readonly DependencyProperty LinkDataProperty;
        public ToDoItem LinkData
        {
            set { SetValue(LinkDataProperty, value); }
            get { return (ToDoItem)GetValue(LinkDataProperty); }
        }

        static Link() 
        {
            LinkDataProperty = 
                DependencyProperty.Register("LinkData", typeof(ToDoItem), typeof(Link));
        }

        protected override void OnMouseDown(System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            MessageBox.Show("id: " + this.LinkData.Id + ", name: " + this.LinkData.Title);
        }
    }
}