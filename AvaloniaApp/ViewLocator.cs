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
        var type = Type.GetType(name);

        if (type is null)
            return new TextBlock { Text = "Not Found: " + name };

        return (Control)Activator.CreateInstance(type)!;
    }

    public bool Match(object? data)
    {
        return data is IViewModel;
    }
}
