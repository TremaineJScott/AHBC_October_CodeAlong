using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionManager
{
    public interface ICollection
    {
        IEnumerable<ICollectable> Collection { get; set; }

        public void Add(ICollectable item);

        ICollectable GetItem();

        
    }
}
