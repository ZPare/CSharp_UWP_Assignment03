﻿#pragma checksum "C:\Users\Zoe\Desktop\Programming 3\Assignments\Assignment 3\Assignment3_UWPSQLite\Proj1\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "084DA3B98B1FB121F60185799DAC0D06"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proj1
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Microsoft_Toolkit_Uwp_UI_Controls_DataGrid_ItemsSource(global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid obj, global::System.Collections.IEnumerable value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.IEnumerable) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.IEnumerable), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::Proj1.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ComboBox obj8;
            private global::Windows.UI.Xaml.Controls.ComboBox obj9;
            private global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid obj11;
            private global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid obj12;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 8: // MainPage.xaml line 59
                        this.obj8 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    case 9: // MainPage.xaml line 65
                        this.obj9 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    case 11: // MainPage.xaml line 39
                        this.obj11 = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)target;
                        break;
                    case 12: // MainPage.xaml line 32
                        this.obj12 = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)target;
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Proj1.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Proj1.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_comboBox1Items(obj.comboBox1Items, phase);
                        this.Update_comboBox2Items(obj.comboBox2Items, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_dataGrid2Items(obj.dataGrid2Items, phase);
                        this.Update_dataGrid1Items(obj.dataGrid1Items, phase);
                    }
                }
            }
            private void Update_comboBox1Items(global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Fruit> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 59
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj8, obj, null);
                }
            }
            private void Update_comboBox2Items(global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Planet> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 65
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj9, obj, null);
                }
            }
            private void Update_dataGrid2Items(global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Planet> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_dataGrid2Items(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 39
                    XamlBindingSetters.Set_Microsoft_Toolkit_Uwp_UI_Controls_DataGrid_ItemsSource(this.obj11, obj, null);
                }
            }
            private void Update_dataGrid1Items(global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Fruit> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_dataGrid1Items(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 32
                    XamlBindingSetters.Set_Microsoft_Toolkit_Uwp_UI_Controls_DataGrid_ItemsSource(this.obj12, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MainPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MainPage_obj1_Bindings> weakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public MainPage_obj1_Bindings TryGetBindingObject()
                {
                    MainPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_dataGrid2Items(null);
                    UpdateChildListeners_dataGrid1Items(null);
                }

                public void PropertyChanged_dataGrid2Items(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Planet> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Planet>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_dataGrid2Items(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Planet> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Planet>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Planet> cache_dataGrid2Items = null;
                public void UpdateChildListeners_dataGrid2Items(global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Planet> obj)
                {
                    if (obj != cache_dataGrid2Items)
                    {
                        if (cache_dataGrid2Items != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_dataGrid2Items).PropertyChanged -= PropertyChanged_dataGrid2Items;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_dataGrid2Items).CollectionChanged -= CollectionChanged_dataGrid2Items;
                            cache_dataGrid2Items = null;
                        }
                        if (obj != null)
                        {
                            cache_dataGrid2Items = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_dataGrid2Items;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_dataGrid2Items;
                        }
                    }
                }
                public void PropertyChanged_dataGrid1Items(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Fruit> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Fruit>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_dataGrid1Items(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Fruit> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Fruit>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Fruit> cache_dataGrid1Items = null;
                public void UpdateChildListeners_dataGrid1Items(global::System.Collections.ObjectModel.ObservableCollection<global::Proj1.Fruit> obj)
                {
                    if (obj != cache_dataGrid1Items)
                    {
                        if (cache_dataGrid1Items != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_dataGrid1Items).PropertyChanged -= PropertyChanged_dataGrid1Items;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_dataGrid1Items).CollectionChanged -= CollectionChanged_dataGrid1Items;
                            cache_dataGrid1Items = null;
                        }
                        if (obj != null)
                        {
                            cache_dataGrid1Items = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_dataGrid1Items;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_dataGrid1Items;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.call_page_loaded;
                }
                break;
            case 2: // MainPage.xaml line 94
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.call_LINQ_Project_QS_Button_Click;
                }
                break;
            case 3: // MainPage.xaml line 99
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.call_LINQ_Filter_QS_Button_Click;
                }
                break;
            case 4: // MainPage.xaml line 104
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.call_LINQ_Order_Ascending_QS_Button_Click;
                }
                break;
            case 5: // MainPage.xaml line 109
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.call_LINQ_Inner_Join_QS_Button_Click;
                }
                break;
            case 6: // MainPage.xaml line 81
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.call_Clear_Button_Click;
                }
                break;
            case 7: // MainPage.xaml line 86
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.call_delete_selected_row_Button_Click;
                }
                break;
            case 8: // MainPage.xaml line 59
                {
                    this.fruitComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.fruitComboBox).SelectionChanged += this.call_ComboBox_fruitSelection;
                }
                break;
            case 9: // MainPage.xaml line 65
                {
                    this.planetComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.planetComboBox).SelectionChanged += this.call_ComboBox_planetSelection;
                }
                break;
            case 10: // MainPage.xaml line 46
                {
                    this.dataGrid3 = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)(target);
                }
                break;
            case 11: // MainPage.xaml line 39
                {
                    this.dataGrid2 = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)(target);
                    ((global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)this.dataGrid2).SelectionChanged += this.call_DataGrid_planetSelection;
                }
                break;
            case 12: // MainPage.xaml line 32
                {
                    this.dataGrid1 = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)(target);
                    ((global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)this.dataGrid1).SelectionChanged += this.call_DataGrid_fruitSelection;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

