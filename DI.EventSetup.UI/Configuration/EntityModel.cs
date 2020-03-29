using Caliburn.Micro;

namespace DI.EventSetup.UI.Configuration
{
    public class EntityModel<T> : Screen
    {
        private T _model;

        public EntityModel(T entity)
        {
            Model = entity;
        }

        protected T Model
        {
            get => _model;
            set => Set(ref _model, value);
        }
    }
}
