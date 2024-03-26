# Xamarin Rotator (SfRotator)

The Rotator is a data control used to display image data and navigate through them. The images can be selected either by Thumbnail or by Dots support.

For know more details about Rotator: https://www.syncfusion.com/xamarin-ui-controls/xamarin-rotator

Rotator user guide documentation: https://help.syncfusion.com/xamarin/rotator/getting-started

## DataTemplateSelector in Xamarin Rotator (SfRotator)
SfRotator supports DataTemplateSelector which you can choose a DataTemplate based on the data object.

**[XAML]**

```
<ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="DefaultTemplate">
                <Grid>
                <Image Source="{Binding Image}" HorizontalOptions="Center" VerticalOptions="Center"/>
                </Grid>
            </DataTemplate>
            <DataTemplate x:Key="SpecificTemplate">
                <Grid>
                <Label Text="Not Available" FontSize="Large" HorizontalOptions="Center" VerticalOptions="Center" FontAttributes="Italic" FontFamily="Calibri"/>
                <Image Source="{Binding Image}" Opacity="0.5" HorizontalOptions="Center" VerticalOptions="Center"/>
                </Grid>
            </DataTemplate>
        </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.Content>      
        <Grid >
         <syncfusion:SfRotator x:Name="sfRotator" 
                    ItemsSource="{Binding ImageCollection}" >
              <syncfusion:SfRotator.ItemTemplate>
                <local:DataTemplateViewModel DefaultTemplate="{StaticResource DefaultTemplate}" SpecificTemplate="{StaticResource SpecificTemplate}"/>
              </syncfusion:SfRotator.ItemTemplate>
         </syncfusion:SfRotator>
        </Grid>
     </ContentPage.Content>
    </ContentPage>
OnSelectTemplate
The OnSelectTemplate is a overridden method to return a particular DataTemplate, which shown in the following code:
```
**[C#]**

```
public class DataTemplateViewModel : DataTemplateSelector
    {
        private DataTemplate defaulttemplate;

        public DataTemplate DefaultTemplate
        {
            get { return defaulttemplate; }
            set { defaulttemplate = value; }
        }

        private DataTemplate specifictemplate;

        public DataTemplate SpecificTemplate
        {
            get { return specifictemplate; }
            set { specifictemplate = value; }
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = item as Model;
            if (message == null)
                return null;
                        return message.Image.ToString() == "movie2.png" ? SpecificTemplate : DefaultTemplate;

        }
    }
```
## How to run this application?

To run this application, you need to first clone the data-template-selector-rotator repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.