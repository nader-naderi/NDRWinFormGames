namespace NDRFormsGameEngine
{
    public static class InputManager
    {
        public static bool IsMoving { get; set; } = ArrowLeft || ArrowDown || ArrowRight || ArrowUp;
        public static Point Horizntal { get; set; }
        public static Point Vertical { get; set; }
        public static bool ArrowLeft { get; set; }
        public static bool ArrowRight { get; set; }
        public static bool ArrowUp { get; set; }
        public static bool ArrowDown{ get; set; }
        public static bool Fire{ get; set; }
    }
}
