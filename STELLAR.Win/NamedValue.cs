using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STELLAR.APP
{
    public interface INamedValue<T>
    {
        String name { get; set; }
        T value { get; set; }
    }
    public abstract class NamedValue<T> : INamedValue<T>
    {
        private String _name;
        private T _value;

        public NamedValue()
        {
            _name = String.Empty;
        }
        public NamedValue(String name)
        {
            _name = name;
        }
        public NamedValue(String name, T value)
        {
            _name = name;
            _value = value;
        }

        public String name
        {
            get { return _name; }
            set { _name = value; }
        }
        public T value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
    //Convenience class...
    public class NamedString : NamedValue<String>, INamedValue<String>
    {
        public NamedString() : base() { }
        public NamedString(String name) : base(name) { }
        public NamedString(String name, String value) : base(name, value) { }
        public new String value
        {
            get {  return base.value; }
            set {  base.value = value; }
        }
    }
}
