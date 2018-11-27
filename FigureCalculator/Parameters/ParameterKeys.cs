namespace Solution.Parameters
{
    /// <summary>
    /// Не думаю что это лучшее решение, но с ключами Dictionary я предпочитаю работать так, во избежании опечаток.  
    /// </summary>
    public class ParameterKeys
    {
        public const string Radius = nameof(Radius);
        public const string Length = nameof(Length);
        public const string Width = nameof(Width);
        public const string Triangle = nameof(Triangle);
        public const string Func = nameof(Func);
    }
}