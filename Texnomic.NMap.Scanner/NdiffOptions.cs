using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texnomic.NMap.Scanner
{
    /// <summary>
    ///     Class which represents command-line options for ndiff
    /// </summary>
    public class NdiffOptions : IDictionary<NdiffFlag, string>
    {
        #region NdiffFlagToOption

        private readonly Dictionary<NdiffFlag, string> _ndiffFlagToOption = new Dictionary<NdiffFlag, string>
            {
                {NdiffFlag.Text, "--text"},
                {NdiffFlag.Xml, "--xml"},
                {NdiffFlag.Verbose, "-v"},
                {NdiffFlag.Help, "-h"}
            };

        #endregion

        #region NmapOptionToFlag

        private readonly Dictionary<string, NdiffFlag> _ndiffOptionToFlag = new Dictionary<string, NdiffFlag>
            {
                {"--text", NdiffFlag.Text},
                {"--xml", NdiffFlag.Xml},
                {"-v", NdiffFlag.Verbose},
                {"-h", NdiffFlag.Help}
            };

        #endregion

        private readonly Dictionary<string, string> _ndiffOptions;

        public NdiffOptions()
        {
            _ndiffOptions = new Dictionary<string, string>();
        }

        public void Add(KeyValuePair<NdiffFlag, string> Kvp)
        {
            Add(Kvp.Key, Kvp.Value);
        }

        public void Clear()
        {
            _ndiffOptions.Clear();
        }

        public bool Contains(KeyValuePair<NdiffFlag, string> Item)
        {
            return _ndiffOptions.Contains(new KeyValuePair<string, string>(_ndiffFlagToOption[Item.Key], Item.Value));
        }

        public void CopyTo(KeyValuePair<NdiffFlag, string>[] Array, int ArrayIndex)
        {
            _ndiffOptions.Select(X => new KeyValuePair<NdiffFlag, string>(_ndiffOptionToFlag[X.Key], X.Value))
                        .ToArray()
                        .CopyTo(Array, ArrayIndex);
        }

        public bool Remove(KeyValuePair<NdiffFlag, string> Item)
        {
            return _ndiffOptions.Remove(_ndiffFlagToOption[Item.Key]);
        }

        public int Count => _ndiffOptions.Count;

        public bool IsReadOnly => false;

        public bool ContainsKey(NdiffFlag Key)
        {
            return _ndiffOptions.ContainsKey(_ndiffFlagToOption[Key]);
        }

        public void Add(NdiffFlag Flag, string Argument)
        {
            var Option = _ndiffFlagToOption[Flag];

            if (_ndiffOptions.ContainsKey(Option))
            {
                _ndiffOptions[Option] = $"{_ndiffOptions[Option]},{Argument}";
            }
            else
            {
                _ndiffOptions.Add(Option, Argument);
            }
        }

        public bool Remove(NdiffFlag Key)
        {
            return _ndiffOptions.Remove(_ndiffFlagToOption[Key]);
        }

        public bool TryGetValue(NdiffFlag Key, out string Value)
        {
            return _ndiffOptions.TryGetValue(_ndiffFlagToOption[Key], out Value);
        }

        public string this[NdiffFlag Key]
        {
            get => _ndiffOptions[_ndiffFlagToOption[Key]];
            set => _ndiffOptions[_ndiffFlagToOption[Key]] = value;
        }

        public ICollection<NdiffFlag> Keys
        {
            get { return _ndiffOptions.Select(X => _ndiffOptionToFlag[X.Key]).ToArray(); }
        }

        public ICollection<string> Values => _ndiffOptions.Values;


        public IEnumerator<KeyValuePair<NdiffFlag, string>> GetEnumerator()
        {
            return
                _ndiffOptions.Select(X => new KeyValuePair<NdiffFlag, string>(_ndiffOptionToFlag[X.Key], X.Value))
                            .GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(NdiffFlag Flag)
        {
            Add(Flag, string.Empty);
        }

        public void AddAll(IEnumerable<NdiffFlag> Flags)
        {
            foreach (var Flag in Flags)
            {
                Add(Flag);
            }
        }

        public void AddAll(IEnumerable<KeyValuePair<NdiffFlag, string>> Kvps)
        {
            foreach (var Kvp in Kvps)
            {
                Add(Kvp.Key, Kvp.Value);
            }
        }

        public override string ToString()
        {
            return
                _ndiffOptions.Aggregate(new StringBuilder(), (Sb, Kvp) => Sb.AppendFormat("{0} {1} ", Kvp.Key, Kvp.Value),
                                       Sb => Sb.ToString()).Trim();
        }
    }
}
