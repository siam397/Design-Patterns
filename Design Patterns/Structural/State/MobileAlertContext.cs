namespace Design_Patterns.Structural.State
{
    public class MobileAlertContext
    {
        private IMobileAlertState _state;
        public MobileAlertContext(IMobileAlertState state)
        {
            _state = state;
        }
        
        public void SetState(IMobileAlertState state)
        {
            _state = state;
        }

        public void HandleOperation()
        {
            this._state.Alert();
        }

    }
}
