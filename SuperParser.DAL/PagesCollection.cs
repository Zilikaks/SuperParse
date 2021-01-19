using SuperParser.DAL.Interfaces;
using SuperParser.Infrastructure.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace SuperParser.DAL
{
    public class PagesCollection<T> : IPagesEnumerable<T>
    { 
        private PagesEnumerator<T> _enumerator;
        private ILoader<T> _loader;
        private IParserSettings _settings;

        public PagesCollection(ILoader<T> htmlLoader, IParserSettings settings)
        {
            _loader = htmlLoader;
            _settings = settings;
            _enumerator = new PagesEnumerator<T>(_loader, _settings);
        }

        public IEnumerator<T> GetEnumerator() => _enumerator;
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void SetSettings(IParserSettings settings)
        {
            _settings = settings;
            _enumerator = new PagesEnumerator<T>(_loader, _settings);
        }

        public void SetHtmlLoader(ILoader<T> loader)
        {
            _loader = loader;
            _enumerator = new PagesEnumerator<T>(_loader, _settings);
        }
    }
}
