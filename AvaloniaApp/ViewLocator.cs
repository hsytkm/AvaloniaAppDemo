using AppViewModels;
using Avalonia.Controls;
using Avalonia.Controls.Templates;

namespace AvaloniaApp;

public sealed class ViewLocator : IDataTemplate
{
    public IControl Build(object? data)
    {
        ArgumentNullException.ThrowIfNull(data, nameof(data));

        var name = data.GetType().FullName!.Replace("ViewModel", "View");

        if (Type.GetType(name) is { } type)
            return (Control)Activator.CreateInstance(type)!;

        return new TextBlock { Text = "Not Found: " + name };
    }

    public bool Match(object? data)
    {
        return data is IViewModel;
    }
}
