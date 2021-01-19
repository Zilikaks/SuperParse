using SuperParser.DAL.Interfaces;
using SuperParser.Infrastructure.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperParser.DAL
{
    public class PagesEnumerator<T> : IEnumerator<T>
    {
        public T Current { get; private set; }
        object IEnumerator.Current => Current;

        private readonly ILoader<T> _loader;
        private readonly IParserSettings _settings;
        private int _currentPos;

        public PagesEnumerator(ILoader<T> htmlLoader, IParserSettings parserSettings) => 
            (_loader, _currentPos, _settings) = (htmlLoader, parserSettings.StartPage-1, parserSettings);

        private async Task<bool> GetCurrent()
        {
            try
            {
                var url = $"{_settings.BaseUrl}{_settings.Pagination}{_currentPos}";
                Current = await _loader.GetResponseAsync(url).ConfigureAwait(false);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool MoveNext()
        {
            if (_currentPos == _settings.EndPage)
            {
                Reset();
                return false;
            }

            _currentPos++;
            return GetCurrent().GetAwaiter().GetResult();
        }

        public void Reset() => _currentPos = _settings.StartPage;

        public void Dispose()
        {
        }
    }
}
