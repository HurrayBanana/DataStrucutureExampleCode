# How to use these files

These class files will need **libraries** adding to their tops to work in your projects and putting inside your projects **namespace**

```
//example standard library includes
using System;
using System.Collections.Generic;
using System.Text;

```

for example here is one way to edit the  **linkedListNode.cs** file 

raw **LinkedListNode.cs** file
```
    /// <summary>
    /// holds a node of list data
    /// </summary>
    class LListNode
    {
        public LListNode next;
        public string name;
        public LListNode(string givenName)
        {
            name = givenName;
        }
    }
```

File after including libraries and namespace

```
//standard libraries
using System;
using System.Collections.Generic;
using System.Text;

//use your projects namespace
namespace DataStructures
{
    /// <summary>
    /// holds a node of list data
    /// </summary>
    class LListNode
    {
        public LListNode next;
        public string name;
        public LListNode(string givenName)
        {
            name = givenName;
        }
    }
}
```
