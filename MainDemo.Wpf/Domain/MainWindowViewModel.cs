﻿using System.Linq;
using System.Windows.Controls;
using MaterialDesignDemo;
using MaterialDesignDemo.Domain;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;

namespace MaterialDesignColors.WpfExample.Domain
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            DemoItems = new[]
            {
                new DemoItem("Home", new Home(), 
                    new []
                    {
                        new DocumentationLink(DocumentationLinkType.Wiki, "https://github.com/ButchersBoy/MaterialDesignInXamlToolkit/wiki", "WIKI"),
                        DocumentationLink.DemoPageLink<Home>()
                    }
                ),
                new DemoItem("Palette", new PaletteSelector { DataContext = new PaletteSelectorViewModel() }, 
                    new []
                    {
                        DocumentationLink.WikiLink("Brush-Names", "Brushes"),
                        DocumentationLink.WikiLink("Custom-Palette-Hues", "Custom Palettes"),
                        DocumentationLink.WikiLink("Swatches-and-Recommended-Colors", "Swatches"),
                        DocumentationLink.DemoPageLink<PaletteSelector>("Demo View"),
                        DocumentationLink.DemoPageLink<PaletteSelectorViewModel>("Demo View Model"),
                        DocumentationLink.ApiLink<PaletteHelper>()
                    }),
                new DemoItem("Buttons & Toggles", new Buttons(),
                    new []
                    {
                        DocumentationLink.WikiLink("Button-Styles", "Buttons"),
                        DocumentationLink.DemoPageLink<Buttons>(),
                        DocumentationLink.StyleLink("Button"),
                        DocumentationLink.StyleLink("CheckBox"),
                        DocumentationLink.StyleLink("PopupBox"),
                        DocumentationLink.StyleLink("ToggleButton"),
                        DocumentationLink.ApiLink<PopupBox>()
                    }
                ),
                new DemoItem("Fields", new TextFields(),
                    new []
                    {                        
                        DocumentationLink.DemoPageLink<TextFields>(),
                        DocumentationLink.StyleLink("TextBox"),
                        DocumentationLink.StyleLink("ComboBox"),                        
                    }),
                new DemoItem("Pickers", new Pickers { DataContext = new PickersViewModel()},
                    new []
                    {
                        DocumentationLink.DemoPageLink<TextFields>(),
                        DocumentationLink.StyleLink("Clock"),
                        DocumentationLink.StyleLink("DatePicker"),
                        DocumentationLink.ApiLink<TimePicker>()
                    }),
                new DemoItem("Sliders", new Sliders(), new []
                    {
                        DocumentationLink.DemoPageLink<Sliders>(),
                        DocumentationLink.StyleLink("Sliders")                        
                    }),
                new DemoItem("Chips", new Chips(), new []
                    {
                        DocumentationLink.DemoPageLink<Chips>(),
                        DocumentationLink.StyleLink("Chip"),
                        DocumentationLink.ApiLink<Chip>()
                    }),
                new DemoItem("Typography", new Typography(), new []
                    {
                        DocumentationLink.DemoPageLink<Typography>(),
                        DocumentationLink.StyleLink("TextBlock")
                    }),
                new DemoItem("Cards", new Cards(), new []
                    {
                        DocumentationLink.DemoPageLink<Cards>(),
                        DocumentationLink.StyleLink("Card"),
                        DocumentationLink.ApiLink<Card>()
                    }),
                new DemoItem("Icon Pack", new IconPack { DataContext = new IconPackViewModel() },
                    new []
                    {                        
                        DocumentationLink.DemoPageLink<IconPack>("Demo View"),
                        DocumentationLink.DemoPageLink<IconPackViewModel>("Demo View Model"),
                        DocumentationLink.ApiLink<PackIcon>()
                    }),
                new DemoItem("Colour Zones", new ColorZones(),
                    new []
                    {
                        DocumentationLink.DemoPageLink<ColorZones>(),
                        DocumentationLink.ApiLink<ColorZone>()
                    }),
                new DemoItem("Lists", new Lists { DataContext = new ListsAndGridsViewModel()},
                    new []
                    {
                        DocumentationLink.DemoPageLink<Lists>("Demo View"),
                        DocumentationLink.DemoPageLink<ListsAndGridsViewModel>("Demo View Model"),
                        DocumentationLink.StyleLink("ListBox")                        
                    }),
                new DemoItem("Trees", new Trees { DataContext = new TreesViewModel() },
                    new []
                    {                        
                        DocumentationLink.DemoPageLink<Trees>("Demo View"),
                        DocumentationLink.DemoPageLink<TreesViewModel>("Demo View Model"),
                        DocumentationLink.StyleLink("TreeView")
                    }),
                new DemoItem("Grids", new Grids { DataContext = new ListsAndGridsViewModel()},
                    new []
                    {                        
                        DocumentationLink.DemoPageLink<Lists>("Demo View"),
                        DocumentationLink.DemoPageLink<ListsAndGridsViewModel>("Demo View Model"),
                        DocumentationLink.StyleLink("DataGrid")
                    }),
                new DemoItem("Expander", new Expander(),
                    new []
                    {
                        DocumentationLink.DemoPageLink<Expander>(),
                        DocumentationLink.StyleLink("Expander")
                    }),
                new DemoItem("Group Boxes", new GroupBoxes(),
                    new []
                    {
                        DocumentationLink.DemoPageLink<Cards>(),
                        DocumentationLink.StyleLink("Card")
                    }),
                new DemoItem("Menus & Tool Bars", new MenusAndToolBars(),
                    new []
                    {
                        DocumentationLink.DemoPageLink<MenusAndToolBars>(),
                        DocumentationLink.StyleLink("Menu"),
                        DocumentationLink.StyleLink("ToolBar")
                    }),
                new DemoItem("Progress Indicators", new Progress(),
                    new []
                    {
                        DocumentationLink.DemoPageLink<Progress>(),
                        DocumentationLink.StyleLink("ProgressBar")
                    }),
                new DemoItem("Dialogs", new Dialogs { DataContext = new DialogsViewModel()},
                    new []
                    {
                        DocumentationLink.WikiLink("Dialogs", "Dialogs"),
                        DocumentationLink.DemoPageLink<Dialogs>("Demo View"),
                        DocumentationLink.DemoPageLink<DialogsViewModel>("Demo View Model"),
                        DocumentationLink.ApiLink<DialogHost>()
                    }),
                new DemoItem("Drawer", new Drawers(),
                    new []
                    {
                        DocumentationLink.DemoPageLink<Drawers>(),
                        DocumentationLink.ApiLink<DrawerHost>()
                    }),
                new DemoItem("Snackbar", new Snackbars(),
                    new []
                    {
                        DocumentationLink.WikiLink("Snackbar", "Snackbar"),
                        DocumentationLink.DemoPageLink<Snackbars>(),
                        DocumentationLink.StyleLink("Snackbar"),
                        DocumentationLink.ApiLink<Snackbar>(),
                        DocumentationLink.ApiLink<ISnackbarMessageQueue>()
                    }),
                new DemoItem("Transitions", new Transitions(),
                    new []
                    {
                        DocumentationLink.WikiLink("Transitions", "Transitions"),
                        DocumentationLink.DemoPageLink<Transitions>(),
                        DocumentationLink.ApiLink<Transitioner>("Transitions"),
                        DocumentationLink.ApiLink<TransitionerSlide>("Transitions"),
                        DocumentationLink.ApiLink<TransitioningContent>("Transitions"),
                    }),
                new DemoItem("Shadows", new Shadows(),
                    new []
                    {
                        DocumentationLink.DemoPageLink<Shadows>(),                        
                    }),
            };
        }

        public DemoItem[] DemoItems { get; }
    }
}