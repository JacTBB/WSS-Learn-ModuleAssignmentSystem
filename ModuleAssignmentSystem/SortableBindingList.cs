using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ModuleAssignmentSystem
{
    /// <summary>
    /// SortableBindingList from https://codecisions.com/datagridview-sorting-using-custom-bindinglist/
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// Seriously, why is this not an inbuilt class. Microsoft's solution for this is also confusing...
    /// I have not understood this code I..., as the practical future use for it is low due to databases.
    public class SortableBindingList<T> : BindingList<T>
    {

        private bool isSorting;

        /// <summary>
        /// Raised when the list is sorted.
        /// </summary>
        public event EventHandler Sorted;

        public SortableBindingList()
            : this(null) { }

        public SortableBindingList(IEnumerable<T> contents)
            : this(contents, null) { }

        public SortableBindingList(IEnumerable<T> contents, ISortComparer<T> comparer)
        {
            if (contents != null)
                AddRange(contents);

            if (comparer == null)
                SortComparer = new GenericSortComparer<T>();
            else
                SortComparer = comparer;
        }

        #region Properties
        private ISortComparer<T> sortComparer;
        public ISortComparer<T> SortComparer
        {
            get { return sortComparer; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("SortComparer", "Value cannot be null.");
                sortComparer = value;
            }
        }

        private bool isSorted;
        protected override bool IsSortedCore
        {
            get { return isSorted; }
        }

        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

        private ListSortDirection sortDirection;
        protected override ListSortDirection SortDirectionCore
        {
            get { return sortDirection; }
        }

        private PropertyDescriptor sortProperty;
        protected override PropertyDescriptor SortPropertyCore
        {
            get { return sortProperty; }
        }
        #endregion

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            if (prop == null)
                return;

            isSorting = true;
            sortDirection = direction;
            sortProperty = prop;
            this.SortComparer.SortProperty = prop;
            this.SortComparer.SortDirection = direction;
            ((List<T>)this.Items).Sort(this.SortComparer);
            isSorted = true;
            isSorting = false;
            this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));
            OnSorted(null, new EventArgs());
        }

        protected override void RemoveSortCore()
        {
            throw new NotSupportedException();
        }

        protected override void OnListChanged(ListChangedEventArgs e)
        {
            if (!isSorting)
                base.OnListChanged(e);
        }

        protected virtual void OnSorted(object sender, EventArgs e)
        {
            if (Sorted != null)
                Sorted(sender, e);
        }

        protected override void InsertItem(int index, T item)
        {
            base.InsertItem(index, item);
            if (!isSorting)
                this.ApplySortCore(this.SortPropertyCore, this.SortDirectionCore);
        }

        protected override void SetItem(int index, T item)
        {
            base.SetItem(index, item);
            if (!isSorting)
                this.ApplySortCore(this.SortPropertyCore, this.SortDirectionCore);
        }

        protected override void RemoveItem(int index)
        {
            base.RemoveItem(index);
            if (!isSorting)
                this.ApplySortCore(this.SortPropertyCore, this.SortDirectionCore);
        }

        protected override void ClearItems()
        {
            base.ClearItems();
        }

        public void AddRange(IEnumerable<T> items)
        {
            if (items != null)
                foreach (T item in items)
                    this.Items.Add(item);
        }
    }

    public class GenericSortComparer<T> : ISortComparer<T>
    {
        public GenericSortComparer()
        {
        }

        public GenericSortComparer(string sortProperty, ListSortDirection sortDirection)
            : this(TypeDescriptor.GetProperties(typeof(T)).Find(sortProperty, true), sortDirection)
        {
        }

        public GenericSortComparer(PropertyDescriptor sortProperty, ListSortDirection sortDirection)
        {
            this.SortDirection = sortDirection;
            this.SortProperty = sortProperty;
        }

        public PropertyDescriptor SortProperty { get; set; }
        public ListSortDirection SortDirection { get; set; }

        public int Compare(T x, T y)
        {
            if (this.SortProperty == null)
                return 0;

            IComparable obj1 = this.SortProperty.GetValue(x) as IComparable;
            IComparable obj2 = this.SortProperty.GetValue(y) as IComparable;
            if (obj1 == null || obj2 == null)
                return 0;

            if (this.SortDirection == ListSortDirection.Ascending)
                return (obj1.CompareTo(obj2));
            else
                return (obj2.CompareTo(obj1));
        }
    }

    public interface ISortComparer<T> : IComparer<T>
    {
        PropertyDescriptor SortProperty { get; set; }
        ListSortDirection SortDirection { get; set; }
    }
}
