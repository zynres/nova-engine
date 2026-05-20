using Silk.NET.GLFW;

namespace input;

public unsafe static class Input
{
    private static WindowHandle* window;
    private static Glfw glfw;

    public static void Init(WindowHandle* _window, Glfw _glfw)
    {
        window = _window;
        glfw = _glfw;
    }

    public static bool GetKeyDown(Keys key)
    {
        return InputAction.Press == (InputAction)glfw.GetKey(window, key);
    }

    public static bool GetKeyUp(Keys key)
    {
        return InputAction.Release == (InputAction)glfw.GetKey(window, key);
    }

    public static bool GetKey(Keys key)
    {
        return InputAction.Repeat == (InputAction)glfw.GetKey(window, key);
    }
}