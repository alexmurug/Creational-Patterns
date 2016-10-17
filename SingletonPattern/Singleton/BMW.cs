namespace SingletonPattern.Singleton
{
    public sealed class Bmw
    {
        private static volatile Bmw _instance;
        private static readonly object LockThis = new object();

        private Bmw()
        {
        }

        // State Information
        public string Model { get; set; }
        public int MotorV { get; set; }

        public static Bmw GetState()
        {
            lock (LockThis)
            {
                _instance = _instance ?? new Bmw();
                return _instance;
            }
        }
    }
}