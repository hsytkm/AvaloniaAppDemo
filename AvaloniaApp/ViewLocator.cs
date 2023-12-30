using AppViewModels;
using Avalonia.Controls;
using Avalonia.Controls.Templates;

namespace AvaloniaApp;

public sealed class ViewLocator : IDataTemplate
{
    public Control? Build(object? data)
    {
        ArgumentNullException.ThrowIfNull(data, nameof(data));

        var name = data.GetType().FullName!.Replace("ViewModel", "View");

#pragma warning disable IL2057 // Unrecognized value passed to the parameter of method. It's not possible to guarantee the availability of the target type.
        var type = Type.GetType(name);
#pragma warning restore IL2057 // Unrecognized value passed to the parameter of method. It's not possible to guarantee the availability of the target type.

        if (type is null)
            return new TextBlock { Text = "Not Found: " + name };

        return (Control)Activator.CreateInstance(type)!;
    }

    public bool Match(object? data)
    {
        return data is IViewModel;
    }
}
