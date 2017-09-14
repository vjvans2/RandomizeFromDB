using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public static class RemoveAndGet
{
    public static T RAG<T> (this IList<T> list, int IndexToRemove)
        {
            lock(list)
        {
            T value = list[IndexToRemove];
            list.RemoveAt(IndexToRemove);
            return value;
        }
    }

}
