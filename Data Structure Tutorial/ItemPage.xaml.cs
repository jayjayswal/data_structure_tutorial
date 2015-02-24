using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using Windows.ApplicationModel;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Data_Structure_Tutorial
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class ItemPage : Data_Structure_Tutorial.Common.LayoutAwarePage
    {
        public String topic;
        object o = new object();
        SelectionChangedEventArgs b = new SelectionChangedEventArgs(new List<object>(), new List<object>());
        String code;

        public ItemPage()
        {
            this.InitializeComponent();
            
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            try
            {
                pageTitle.Text = navigationParameter.ToString();
                topic = navigationParameter.ToString();
                Itemload();
            }
            catch (Exception q)
            {
                q.ToString();
            }
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
           
        }

  //----------------------------------------------get code from file---------------------------------------------//

        private async void printcode(String s)
        {
            var installationFolder = Package.Current.InstalledLocation;
            var filesFolder = await installationFolder.GetFolderAsync("DS");
            var file = await filesFolder.GetFileAsync(s);
            using (IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
            {
                StreamReader str = new StreamReader(fileStream.AsStream());
                this.code = str.ReadToEnd();
            }
            desc.Text = code;
        }
//---------------------------------------------------------------------------------------------------------------//
//------------------------------------- media element---------------------------------------------------------//
        private void mediacomplited(object sender, RoutedEventArgs e)
        {
            media.Stop();
            play.Content = "Play";
            stop.Visibility = Visibility.Collapsed;
        }
        private void stopmedia()
        {
            media.Stop();
            play.Content = "Play";
            stop.Visibility = Visibility.Collapsed;
        }
        private void aplay(object sender, RoutedEventArgs e)
        {
            if (play.Content.ToString() == "Play")
            {
                media.Play();
                play.Content = "Pause";
                stop.Visibility = Visibility.Visible;
                return;
            }
            if (play.Content.ToString() == "Pause")
            {
                media.Pause();
                play.Content = "Play";
                stop.Visibility = Visibility.Visible;
                return;
            }
        }

        private void astop(object sender, RoutedEventArgs e)
        {
            if (play.Content.ToString() == "Pause" || play.Content.ToString() == "Play")
            {
                media.Stop();
                play.Content = "Play";
                stop.Visibility = Visibility.Collapsed;
            }
        }


//---------------------------------------------------------------------------------------------------//

//--------------------------------------Iteam List--------------------------------------------------//
        private void Itemload()
        {
            if (topic == "Stack")
            {
                a0.Text = "What is stack?";

                a1.Text = "Push()";
                a2.Text = "Pop()";
                a3.Text = "Top value";
                a4.Text = "C++ CODE of Stack";
                a5.Text = "Example ";
                selectionChanged(o, b);

                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);


            }

            if (topic == "Queue")
            {
                a0.Text = "What is Queue? ";
                a1.Text = "Add element in queue";
                a2.Text = "Remove element from queue";
                a3.Text = "Acceptation Case (Reset)";
                a4.Text = "C++ CODE of Queue";
                selectionChanged(o, b);
                item.Items.RemoveAt(5);
                item.Items.RemoveAt(5);
                item.Items.RemoveAt(5);
                item.Items.RemoveAt(5);
                item.Items.RemoveAt(5);
                item.Items.RemoveAt(5);
            }
            if (topic == "Two Stack In One Array")
            {
                a0.FontSize = 25;
                pageTitle.FontSize = 36;
                a0.Text = "Implement two stacks using one array";
                a1.Text = "Insert a value in any Stack";
                a2.Text = "Remove value From Stack";
                a3.Text = "Is empty Condition ";
                a4.Text = "Is Full Condition";
                a5.Text = "C++ CODE";
                selectionChanged(o, b);
                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);
            }
            if (topic == "Circular Queue")
            {
                a0.Text = "What is Circular Queue?";
                a1.Text = "Add element in Circular queue";
                a2.FontSize = 25;
                a2.Text = "Remove element from Cirqular queue";
                a3.Text = "Is full condition";
                a4.Text = "Is Empty condition ";
                a5.Text = "C++ CODE of Circular Queue";
                selectionChanged(o, b);
                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);
                item.Items.RemoveAt(6);
            }
            
            if (topic == "Link List")
            {

                a0.Text = "What is Link List?";
                a1.Text = "Node Structure of Link List";
                a2.Text = "Head pointer";
                a3.FontSize = 25;
                a3.Text = "Add first node or add node at last position";
                a4.FontSize = 25;
                a4.Text = "Add new node as first node(head node)";
                a5.FontSize = 25;
                a5.Text = "Add new node in between link list at some position";
                a6.Text = "Delete first node";
                a7.Text = "Delete last node";
                a8.FontSize = 25;
                a8.Text = "Delete node in between Link List at some position";
                a9.Text = "C++ CODE of Link List";
                selectionChanged(o, b);
                item.Items.RemoveAt(10);
            }

            if (topic == "Circular Link List")
            {
                pageTitle.FontSize = 55;
                a0.Text = "What is Circular Link List?";
                a1.Text = "Node Structure of Circular Link List";
                a2.FontSize = 25;
                a2.Text = "Add first node or add node at last position";
                a3.FontSize = 25;
                a3.Text = "Add new node as first node(head node)";
                a4.FontSize = 25;
                a4.Text = "Add new node in between Circular link list at some position";
                a5.Text = "Delete first node";
                a6.Text = "Delete last node";
                a7.FontSize = 25;
                a7.Text = "Delete node in between Circular Link List at some position";
                a8.Text = "C++ CODE of Circular Link List";
                selectionChanged(o, b);
                item.Items.RemoveAt(9);
                item.Items.RemoveAt(9);

            }

            if (topic == "Doubly Linked List")
            {
                pageTitle.FontSize = 48;
                a0.Text = "What is Doubly link list?";
                a1.Text = "Node Structure of Doubly Link List";
                a2.Text = "Head pointer";
                a3.FontSize = 25;
                a3.Text = "Add first node or add node at last position";
                a4.FontSize = 25;
                a4.Text = "Add new node as first node(head node)";
                a5.FontSize = 25;
                a5.Text = "Add new node in between Doubly link list at some position";
                a6.Text = "Delete first node";
                a7.Text = "Delete last node";
                a8.FontSize = 25;
                a8.Text = "Delete node in between Doubly Link List  at some position";
                a9.Text = "C++ CODE of Doubly Link List";
                selectionChanged(o, b);
                item.Items.RemoveAt(10);
            }

            if (topic == "Circular Doubly Linked List")
            {
                pageTitle.FontSize = 33;
                a0.Text = "What is Circular Doubly Link List?";
                a1.FontSize = 24;
                a1.Text = "Node Structure of Circular Doubly Link List";
                a2.FontSize = 25;
                a2.Text = "Add first node or add node at last position";
                a3.FontSize = 25;
                a3.Text = "Add new node as first node(head node)";
                a4.FontSize = 25;
                a4.Text = "Add new node in between Circular Doubly link list at some position";
                a5.Text = "Delete first node";
                a6.Text = "Delete last node";
                a7.FontSize = 25;
                a7.Text = "Delete node in between Circular Doubly Link List at some position";
                a8.FontSize = 25;
                a8.Text = "C++ CODE of Circular Doubly Link List";
                selectionChanged(o, b);
                item.Items.RemoveAt(9);
                item.Items.RemoveAt(9);
            }

            if (topic == "Binary Trees")
            {
                a0.Text = "What is Binary tree?";
                a1.Text = "Node structure of Binary tree";
                a2.Text = "Binary Tree traversal";
                a3.Text = "Preorder (ILR)";
                a4.Text = "Inorder (LIR) ";
                a5.Text = "Postorder (LRI)";
                a6.Text = "Making Binary tree";
                a7.Text = "Now,How to make a program for binary tree?";
                selectionChanged(o, b);
                item.Items.RemoveAt(8);
                item.Items.RemoveAt(8);
                item.Items.RemoveAt(8);
            }
        }
//------------------------------------------------------------------------------------------------//

//-----------------------------------------Set up data--------------------------------------------//
        private void selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //..........................stack..........................//
                if (topic == "Stack")
                {

                    if (item.SelectedIndex == 0)
                    {
                        String a = "\tStack is a last in-first out (LIFO) abstract data type and linear data structure. A stack can have any abstract data type as an element, but is characterized by two fundamental operations, called push and pop.";
                        itemtitle.Text = a0.Text;
                        desc.Text = a;
                        media.Visibility = Visibility.Collapsed;
                        cmedia.Visibility = Visibility.Collapsed;
                    }

                    if (item.SelectedIndex == 1)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            String a = "\tThe push operation adds a new item to the top of the stack. Push is used to insert a new value in the stack.\n\nExample:-";
                            itemtitle.Text = a1.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/Stack/push.mp4");


                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 2)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            String a = "\tpop( ) is used to get/delete a top value from the stack. pop( ) returns the last entered value.\n\nExample:-";
                            itemtitle.Text = a2.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/Stack/pop.mp4");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 3)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            String a = "\tTOP is a integer which stores index number of the last entered value.\n\n\tWhen Stack initializes, no value is stored in the stack OR the stack is empty.So at that time Top value is  -1 . Stack is then considered to be in underflow state.Any time when new value is pushed firstly top gets incremented[ (top=top+1) OR (++top) ] & then the value gets stored.Example:- array[++top] = value;\n\tAnd when Top value is : 'stacksize - 1' the stack becomes full and does not contain enough space to accept the given item. The stack is now considered to be in overflow state.When any value is popped, top value gets decremented[ (top=top-1) OR (top--) ]\n\nExample:-";
                            itemtitle.Text = a3.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/Stack/top.mp4");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 4)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Collapsed;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.Text = a4.Text;
                            printcode("Stack.txt");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 5)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.Text = a5.Text;
                            String a = "Initializes one stack S\n\n1. S.push(15);\n1. S.push(20)\n3. S.pop( );\n4. S.push(25);\n5. S.push(22);\n6. S.push(35);\n7. S.push(40); // stack is full...\n8. S.pop( );\n9. S.pop( );\n10. S.pop( );\n11. S.pop( );\n12. S.pop( ); // stack is empty.."; itemtitle.Text = a5.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/Stack/example.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                }

                //............................ two stack...................//
                if (topic == "Two Stack In One Array")
                {

                    if (item.SelectedIndex == 0)
                    {
                        this.stopmedia();
                        media.Visibility = Visibility.Visible;
                        cmedia.Visibility = Visibility.Visible;
                        image.Visibility = Visibility.Visible;
                        String a = "The obvious solution is to have the two stacks at the two ends of the array. The stacks will grow in opposite direction.";
                        itemtitle.Text = a0.Text;
                        desc.Text = a;
                        media.Source = new Uri("ms-appx:/DS/2stack/1st.mp4");
                        image.Source = new BitmapImage(new Uri("ms-appx:/DS/2stack/TwoStacksOneArray.png"));
                    }

                    if (item.SelectedIndex == 1)
                    {
                        try
                        {
                            this.stopmedia();
                            image.Visibility = Visibility.Collapsed;
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            String a = "\tFor inserting value in first stack we must first increment a value of  top1.\nAnd For inserting value in secound stack we must first decrement a value of  top2.\n\nImportant Note :- \n\n\tFor deciding which value should be inserted in which stack ,we create one variable 'Sq'. If Sq = 1 then value gets inserted in stack 1 else if Sq = 2 then insert value in stack 2. 'Sq' value is taken from user.";
                            itemtitle.Text = a1.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/2stack/insert.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 2)
                    {
                        try
                        {
                            this.stopmedia();
                            image.Visibility = Visibility.Collapsed;
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            String a = "\tFor removing value from first stack we decrement the value of  top1.For removing value from Second stack we increment the value of  top2.";
                            itemtitle.Text = a2.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/2stack/remove.mp4");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 3)
                    {
                        try
                        {
                            this.stopmedia();
                            image.Visibility = Visibility.Collapsed;
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Collapsed;
                            String a = "";
                            itemtitle.Text = a3.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/2stack/empty.mp4");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 4)
                    {
                        try
                        {
                            this.stopmedia();
                            image.Visibility = Visibility.Collapsed;
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible  ;
                            String a = "";
                            itemtitle.Text = a4.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/2stack/full.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 5)
                    {
                        try
                        {
                            this.stopmedia();
                            image.Visibility = Visibility.Collapsed;
                            media.Visibility = Visibility.Collapsed;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.Text = a5.Text;
                            printcode("2stack.txt");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                }

                //....................queue..............................//
                if (topic == "Queue")
                {

                    if (item.SelectedIndex == 0)
                    {
                        this.stopmedia();
                        media.Visibility = Visibility.Collapsed;
                        cmedia.Visibility = Visibility.Collapsed;
                        String a = "\tQueue is a linear data structure in which data can be added to one end and retrieved from the other. Just like a queue of the real world, the data that goes first into the queue is the first one to be retrieved. That is why queues are sometimes called as First-In-First-Out data structure.In Queues data is added to one end (known as REAR) and retrieved from the other end (known as FRONT).\n\nRear :-A variable stores the index number in the array at which the new data will be added (in the queue).\n\nFront :-It is a variable storing the index number in the array from where the data will be retrieved.";
                        itemtitle.Text = a0.Text;
                        desc.Text = a;
                    }

                    if (item.SelectedIndex == 1)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            String a = "\tFirst we initialize a new queue.At that time 'rear' and 'front' both will be at position -1. When we add 1st element in a queue then first of all we increment value of rear and front both as a 0. And add value at 0 position. After adding first value , to insert any new value we just increment rear and store value at rear position.";
                            itemtitle.Text = a1.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/queue/add_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 2)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            String a = "\tFor removing element from queue we just inrement the value of front.";
                            itemtitle.Text = a2.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/queue/remove_1.mp4");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 3)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            String a = "\tAt some point you see situation in which rear = size - 1 and front has any value except 0. At that time Queue is not full but we can't increment rear value because rear is at the end of queue. At that time we must reset the queue first and then add a new value.";
                            itemtitle.Text = a3.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/queue/reset_1.mp4");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 4)
                    {
                        try
                        {
                            this.stopmedia();
                            image.Visibility = Visibility.Collapsed;
                            media.Visibility = Visibility.Collapsed;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.Text = a4.Text;
                            printcode("queue.txt");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                }

                //............................ circular queue...........................//
                if (topic == "Circular Queue")
                {

                    if (item.SelectedIndex == 0)
                    {
                        this.stopmedia();
                        media.Visibility = Visibility.Collapsed;
                        cmedia.Visibility = Visibility.Collapsed;
                        String a = "In a standard queue data structure re-set problem occurs for each dequeue operation. This problem can be solved by joining the front and rear ends of a queue to make the queue as a circular queue. Circular queue is a linear data structure. It follows FIFO principle. Elements are added at the rear end and the elements are deleted at front end of the queue.";
                        itemtitle.Text = a0.Text;
                        desc.Text = a;
                    }

                    if (item.SelectedIndex == 1)
                    {
                        try
                        {
                            this.stopmedia();
                            image.Visibility = Visibility.Collapsed;
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.Text = a1.Text;
                            desc.Text = "Three different case to add value in Circular Queue.... ";
                            media.Source = new Uri("ms-appx:/DS/cqueue/add_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 2)
                    {
                        try
                        {
                            this.stopmedia();
                            image.Visibility = Visibility.Collapsed;
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 45;
                            itemtitle.Text = a2.Text;
                            desc.Text = "Three different case to Remove value from Circular Queue....";
                            media.Source = new Uri("ms-appx:/DS/cqueue/delete_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 3)
                    {
                        try
                        {
                            this.stopmedia();
                            image.Visibility = Visibility.Collapsed;
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Collapsed;
                            String a = "";
                            itemtitle.Text = a3.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/cqueue/isfull_1.mp4");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 4)
                    {
                        try
                        {
                            this.stopmedia();
                            image.Visibility = Visibility.Collapsed;
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Collapsed;
                            String a = "";
                            itemtitle.Text = a4.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/cqueue/empty_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 5)
                    {
                        try
                        {
                            this.stopmedia();
                            image.Visibility = Visibility.Collapsed;
                            media.Visibility = Visibility.Collapsed;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.Text = a5.Text;
                            printcode("cqueue.txt");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                }


                //.................................Link List...................................//


                if (topic == "Link List")
                {

                    if (item.SelectedIndex == 0)
                    {
                        this.stopmedia();
                        itemtitle.FontSize = 56;
                        media.Visibility = Visibility.Collapsed;
                        cmedia.Visibility = Visibility.Collapsed;
                        String a = "\tLink List is a dynamic data structure. It consists a group of nodes which together, represent a sequence. Under the simplest form, each node is composed of a datum and a reference (in other words, a link) to the next node in the sequence; more complex variants add additional links. This structure allows for efficient insertion or removal of elements from any position in the sequence.";
                        itemtitle.Text = a0.Text;
                        desc.Text = a;
                    }

                    if (item.SelectedIndex == 1)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a1.Text;
                            desc.Text = "\tA Linked List whose nodes contain two fields: an integer value and a link to the next node. The last node is linked to a NULL value ,used to signify the end of the list.In link field we store address of next node.So link is a pointer of datatype node.\n\nStructure:-\n\nstruct node\n{\n\tint data;\n\tstruct node *next; //*next is pointer to store address of next node.\n}\n\nassume we created node with name p.\n\nfor storing value(data) in link list :-\nq->data=value;    e.g. q->data=10;\n\nfor seting a link to next node:-\nq->next=node name    e.g.  q->next=p; //p is another node.\nExample:-";
                            media.Source = new Uri("ms-appx:/DS/linklist/LINK_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 2)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a2.Text;
                            desc.Text = "\tHead pointer is a pointer whose data type is node. this pointer always points first node of link list. so we can use for traversal of link list.";
                            media.Source = new Uri("ms-appx:/DS/linklist/head_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 3)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 40;
                            String a = "\tWhen head pointer points to NULL that means link list is not created.\nif we create a new node and if it's the first node of that link list then, it's called head node.\nThen after if we add some more nodes then it's created at last position like queue. Last node of the linklist is linked with NULL value to show that link list has ended.\n\nExample:-";
                            itemtitle.Text = a3.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/linklist/add_1.mp4");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 4)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 40;
                            String a = "\tWhen we want to make a new node as a head node ,in simple language to add a new node as a first node in existing link list, we must move head pointer to that new node and make link to the old head node from new head hode.\n\n Example:-";
                            itemtitle.Text = a4.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/linklist/add as first_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 5)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 35;
                            String a = "\tIf we want to add a new node at some position then we must travel one variable to that position and change two links from link list. here is code and example....\n\n Example:-";
                            itemtitle.Text = a5.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/linklist/add between_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 6)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            String a = "\tTo delete the first node of the list first, we increment head pointer to second node and then delete that node.\n\n Example:-";
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a6.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/linklist/delete from head_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }

                    }
                    if (item.SelectedIndex == 7)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            String a = "\tTo delete last node, first we change link vlue of second last node with NULL and then delete last node.\n\n Example:-";
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a7.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/linklist/delete from last_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 8)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 35;
                            String a = "\tTo delete node at some position in link list, here is the code and example....\n\n Example:-";
                            itemtitle.Text = a8.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/linklist/delete between_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 9)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Collapsed;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a9.Text;
                            printcode("linklist.txt");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                }

                //....................... circular link list..........................//

                if (topic == "Circular Link List")
                {

                    if (item.SelectedIndex == 0)
                    {
                        this.stopmedia();
                        itemtitle.FontSize = 56;
                        media.Visibility = Visibility.Visible;
                        cmedia.Visibility = Visibility.Collapsed;
                        String a = "\tCircular link list is same as linear link list. The only difference is that the last node does not contain a NULL pointer.Instead, the last node contains a pointer that has the address of first node and thus points back to the first node.\n\nAdvantages:\n\n1. If we are at some node, then we can go to any node. But in linear linked list it is not possible to go to previous node.\n2. It saves time when we have to go to the first node from the last node. It can be done in single step because there is no need to traverse the in between nodes.";
                        itemtitle.Text = a0.Text;
                        desc.Text = a;
                        media.Source = new Uri("ms-appx:/DS/clinklist/Untitled-1_1.mp4");
                    }

                    if (item.SelectedIndex == 1)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Collapsed;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a1.Text;
                            desc.Text = "\tSame as linar Link List. No changes.\n\nStructure:-\n\nstruct node\n{\n\tint data;\n\tstruct node *next; //*next is pointer to store address of next node.\n}";
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 2)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a2.Text;
                            desc.Text = "\tWhen head pointer points to NULL that means link list is not created.\nthen if we create a new node that means it's first node of that link list so it's head node. \nAfter then if we add some more nodes,they're created at last position like queue. last node of the linklist linked with First Node(head node).";
                            media.Source = new Uri("ms-appx:/DS/clinklist/add_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 3)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 40;
                            String a = "\tWhen we want to make a new node as a head node in simple language to add a new node as a first node in exist link list, we must move head pointer to that new node and make link to old head node from new head node. And we travel one variable pointer to last node and make link to first node.\n\nExample:-";
                            itemtitle.Text = a3.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/clinklist/add as first_1.mp4");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 4)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 31;
                            String a = "\tSame As linear link list. no change. :-)\n\n Example:-";
                            itemtitle.Text = a4.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/clinklist/add between_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 5)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            String a = "\tTo delete first node of the list ,first we increment head pointer to second node and then delete that node .And we travel one variable pointer to last node and make link to New Head Node.\n\n Example:-";
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a5.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/clinklist/delete from head_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }

                    }
                    if (item.SelectedIndex == 6)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 56;
                            String a = "\tFor delete last node First we change link vlue fo second last node with Head node. and delete last node.\n\n Example:-";
                            itemtitle.Text = a6.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/clinklist/delete from last_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 7)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 31;
                            String a = "\tSame As linear link list. no change. :-)\n\n Example:-";
                            itemtitle.Text = a7.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/clinklist/delete between_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 8)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Collapsed;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a8.Text;
                            printcode("clinklist.txt");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                }

                //..........................doubly link list.........................//
                if (topic == "Doubly Linked List")
                {

                    if (item.SelectedIndex == 0)
                    {
                        this.stopmedia();
                        media.Visibility = Visibility.Collapsed;
                        cmedia.Visibility = Visibility.Collapsed;
                        itemtitle.FontSize = 56;
                        String a = "\t Doubly-linked list(DLL) is a more sophisticated kind of linked list. In DLL, each node has two links: one points to previous node and one points to next node.The previous link of first node in the list points to a Null and the next link of last node points to Null.\n\nAdvantages:-\n\tA doubly linked list can be traversed in both directions (forward and backward). A singly linked list can only be traversed in one direction.\n\nDisadvantages:-\n\tA node on a doubly linked list may be deleted with little trouble, since we have pointers to the previous and next nodes. A node on a singly linked list cannot be removed unless we have the pointer to its predecessor.On the flip side however, a doubly linked list needs more operations while inserting or deleting and it needs more space (to store the extra pointer).";
                        itemtitle.Text = a0.Text;
                        desc.Text = a;
                    }

                    if (item.SelectedIndex == 1)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Collapsed;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a1.Text;
                            desc.Text = "\tA Linked List whose nodes contain three fields: an integer value, a link to the next node and a link to the previous node.The previous link of first node in the list ,points to a Null. The last node is linked to a NULL value used to signify the end of the list.\n\nStructure:-\n\nstruct node\n{\n\tint data;\n\tstruct node *next; //*next is a pointer to store address of next node.\n\tstruct node *pre; //*pre is a pointer to store address of previous node.\n}";
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 2)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a2.Text;
                            desc.Text = "\tHead pointer is one pointer whose data type is node. this pointer always points first node of link list. so we can use for traversal a link list.\n\nExample:-";
                            media.Source = new Uri("ms-appx:/DS/doublell/Untitled-1_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 3)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 40;
                            String a = "\tWhen head pointer points to NULL that means link list is not created. \nif we create a new node that if first node of that link list so it's head node.\nThen after if we add some more nodes then it's created at last position like queue. last node's next pointer is linked with NULL value to show that link list is ended.\n\nExample:-";
                            itemtitle.Text = a3.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/doublell/add_1.mp4");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 4)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 40;
                            String a = "\tWhen we want to make a new node as a head node in simple language to add a new node as a first node in existing link list we must move head pointer to that new node and manage links to old head node from new head node.\n\n Example:-";
                            itemtitle.Text = a4.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/doublell/add as first_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 5)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 31;
                            String a = "\tIf we want to add new node at some position then we must travel one variable to that position and change four links from link list. here is code and example....\n\n Example:-";
                            itemtitle.Text = a5.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/doublell/add between_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 6)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            String a = "\tTo delete first node of the list first we increment head pointer to second node and then delete that node.\n\n Example:-";
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a6.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/doublell/delete from head_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }

                    }
                    if (item.SelectedIndex == 7)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 56;
                            String a = "\tTo delete last node, First we change next link vlue of second last node with NULL. and then delete last node.\n\n Example:-";
                            itemtitle.Text = a7.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/doublell/delete from last_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 8)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 31;
                            String a = "\tTo delete at some position in link list here is code and example....\n\n Example:-";
                            itemtitle.Text = a8.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/doublell/delete between_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 9)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Collapsed;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a9.Text;
                            printcode("doublell.txt");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                }

                //...................................... circular doubly link list...........................//

                if (topic == "Circular Doubly Linked List")
                {

                    if (item.SelectedIndex == 0)
                    {
                        this.stopmedia();
                        media.Visibility = Visibility.Visible;
                        cmedia.Visibility = Visibility.Collapsed;
                        itemtitle.FontSize = 56;
                        String a = "\tCircular doubly link list is same as linear doubly link list only. The only difference is that, that in it the last node does not contain NULL pointer.Instead the last node contains a next pointer that has the address of first node and the first node contains a previous pointer that has the address of last node.";
                        itemtitle.Text = a0.Text;
                        desc.Text = a;
                        media.Source = new Uri("ms-appx:/DS/cdoublyll/Untitled-1_1.mp4");
                    }

                    if (item.SelectedIndex == 1)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Collapsed;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 40;
                            itemtitle.Text = a1.Text;
                            desc.Text = "\tSame as linar doubly Link List. No changes.\n\nStructure:-\n\nstruct node\n{\n\tint data;\n\tstruct node *next; //*next is pointer to store address of next node.\nstruct node *pre; //*pre is pointer to store address of previous\n}";
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 2)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 40;
                            itemtitle.Text = a2.Text;
                            desc.Text = "\tWhen head pointer points to NULL that means link list is not created. \nthen if we create new node that if first node of that link list so it's head node.\nthen if we add some more node then it's created at last position like queue. last node's next pointer linked with First Node(head node) And head node's previous pointer linked with last node. If there is only one node in doubly link list then next and privous both liked with with head node(same node).\n\nExample:-";
                            media.Source = new Uri("ms-appx:/DS/cdoublyll/add_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 3)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 40;
                            String a = "\tWhen we want to make a new node as a head node in simple language to add a new node as a first node in existing link list we must move head pointer to that new node and make link to old head node from new head node.\n\nExample:-";
                            itemtitle.Text = a3.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/cdoublyll/add as first_1.mp4");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 4)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 27;
                            String a = "\tSame As linear doubly link list. no change. :-)\n\n Example:-";
                            itemtitle.Text = a4.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/cdoublyll/add between_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 5)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 56;
                            String a = "\tTo delete first node of the list first we increment head pointer to second node then delete that node.\n\n Example:-";
                            itemtitle.Text = a5.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/cdoublyll/delete between_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }

                    }
                    if (item.SelectedIndex == 6)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 56;
                            String a = "\tTo delete last node First we change link value of second last node with Head node. and delete last node.\n\n Example:-";
                            itemtitle.Text = a6.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/cdoublyll/delete from head_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 7)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 27;
                            String a = "\tSame As doubly linear link list. no change. :-)\n\n Example:-";
                            itemtitle.Text = a7.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/cdoublyll/delete from last_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 8)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Collapsed;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a8.Text;
                            printcode("cdoublell.txt");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                }

                //......................binary tree..........................//
                if (topic == "Binary Trees")
                {

                    if (item.SelectedIndex == 0)
                    {
                        this.stopmedia();
                        media.Visibility = Visibility.Collapsed;
                        cmedia.Visibility = Visibility.Collapsed;
                        itemtitle.FontSize = 56;
                        String a = "\tA binary tree is a tree data structure in which each node has at most two child nodes, usually distinguished as 'left' and 'right'. Nodes with children are called parent nodes, and child nodes may contain references to their parents.A tree which does not have any node other than root node is called a null tree. In a binary tree a degree of every node is maximum two. A tree with 'n' number of nodes has exactly 'n-1' branches or degree.\n\nA binary tree is full if each node is either a leaf or possesses exactly two child nodes.\nA binary tree with n levels is complete if all levels except possibly the last are completely full, and the last level has all its nodes to the left side.";
                        itemtitle.Text = a0.Text;
                        desc.Text = a;
                    }

                    if (item.SelectedIndex == 1)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a1.Text;
                            desc.Text = "\tNodes contain three fields: an value and a link to the 'left' node and a link to the 'right' node.\nstruct node\n{\n\tint data;\n\tstruct node *left; //*left is pointer to store address of left node.\n\tstruct node *right; //*right is pointer to store address of right node.\n}\n\nExample:-";
                            media.Source = new Uri("ms-appx:/DS/btree/btree_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 2)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Collapsed;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 56;
                            itemtitle.Text = a2.Text;
                            desc.Text = "\ttree traversal refers to the process of visiting (examining and/or updating) each node in a tree data structure, exactly once, in a systematic way. Such traversals are classified by the order in which the nodes are visited. The following algorithms are described for a binary tree, but they may be generalized to other trees as well.\n\nThe names given for particular style of traversal came from the position of the root element with regard to the left and right nodes. Imagine that the left and right nodes are constant in space, then the root node could be placed to the left of the left node (pre-order), between the left and right node (in-order), or to the right of the right node (post-order).";
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 3)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 56;
                            String a = "Preorder (ILR)( I : parent node , L : left node , R : right node )\n\tTo traverse a non-empty binary tree in preorder, perform the following operations recursively at each node, starting with the root node:\n\n1. Visit the root.\n2. Traverse the left subtree.\n3. Traverse the right subtree\n\nExample:-";
                            itemtitle.Text = a3.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/btree/preorder_1.mp4");

                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 4)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 56;
                            String a = "Inorder (LIR)( I : parent node , L : left node , R : right node )\n\tTo traverse a non-empty binary tree in inorder (symmetric), perform the following operations recursively at each node:\n\n1. Traverse the left subtree.\n2. Visit the root.\n3. Traverse the right subtree.\n\n Example:-";
                            itemtitle.Text = a4.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/btree/inorder_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 5)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 56;
                            String a = "Postorder (LRI) ( I : parent node , L : left node , R : right node )\n\tTo traverse a non-empty binary tree in postorder, perform the following operations recursively at each node:\n\n1. Traverse the left subtree.\n2. Traverse the right subtree.\n3. Visit the root.\n\n Example:-";
                            itemtitle.Text = a5.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/btree/postorder_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    if (item.SelectedIndex == 6)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Collapsed;
                            itemtitle.FontSize = 56;
                            String a = "\tTo create binary tree first we want input from user in some perfect manner. For that here is one method for input. In this method user inputs data as one string. From program we analyze that string and make tree.\n\nAssume user input :- (a(b,c))\nhere value which comes before opening bracket that is a parent of values in bracket. in this case a is parent of b and c. now value which comes before ',' (coma) that is left node and after ',' (coma) is a right node. Here are some more Example.\n\n Example:-";
                            itemtitle.Text = a6.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/btree/make tree example_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }

                    }
                    if (item.SelectedIndex == 7)
                    {
                        try
                        {
                            this.stopmedia();
                            media.Visibility = Visibility.Visible;
                            cmedia.Visibility = Visibility.Visible;
                            itemtitle.FontSize = 40;
                            String a = "\tTo make a binary tree we must analyze the input string first. In program we maintain one Stack and one integer variable Pre for make a tree. For analyzing a string we have to follow some rules. From that rules we can make our binary tree.Here is the rules:-\n\n1. if current character is '(' (opening bracket) then normally we push last entered value in stack. but if that '(' is first opening bracket then push NULL in stack and change pre value to 0 in both case.\n2. if current character is ',' (coma) then change pre value to 1.\n3. if current character is ')' (closing bracket) then normally we pop one top value from stack.\n4. if current character is any value (e.g. A,B,C) then first make one new node and save that value in that node. after that check pre value...\n-> if pre value is 0 then make that node as left node of the node which's value stored at top of the stack.\n-> if pre value is 1 then make that node as right node of the node which's value stored at top of the stack.\n-> if there is NULL value at top of the stack then make that node Root node of the tree.\n\n Example:-";
                            itemtitle.Text = a7.Text;
                            desc.Text = a;
                            media.Source = new Uri("ms-appx:/DS/btree/btree makeing_1.mp4");
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                showMessage(ex.ToString());
            }
        }
        private async void showMessage(string p)
        {
            await (new MessageDialog(p)).ShowAsync();
        }



     



    }
}
