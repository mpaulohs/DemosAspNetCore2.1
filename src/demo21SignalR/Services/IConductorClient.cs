namespace demo21SignalR.Services
{
    public interface IConductorClient
    {
        void OnSamplePlayed(Sample sample);
        void IAmHardware();
        void ShowHitCount();
    }
}
