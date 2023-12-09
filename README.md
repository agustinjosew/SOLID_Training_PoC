# SOLID Training
Hands on with SOLID principles using [T4 template](https://learn.microsoft.com/en-us/visualstudio/modeling/code-generation-and-t4-text-templates?view=vs-2022) by [Agustin Jose Wawrzyk](https://www.linkedin.com/in/agustinjosew/).

> What is "T4"?
Another name for the Visual Studio text template capabilities described here. The previous version, which was not published, was an abbreviation for "Text Template Transformation".

**What is the benefit of using text templates?**
Typically, you generate multiple code or other files from one model. The model represents the requirements more directly than the generated code. It omits implementation detail and is written in terms of the requirements, rather than the code. When the requirements change - as they usually do - you can update the model more easily and more reliably than the different parts of the program code.

Code generation is therefore a valuable tool from the perspective of agile development methods.


**Running the Template**: Place the .tt file in the root of your solution directory, and run it to generate the solution and project files.


<details>
<summary>For more details click here! </summary>

If you want to use a T4 template within the context of a Visual Studio project, you can follow these steps to create a blank project and associate the T4 template with that project:

Open Visual Studio 2022.

Create a new empty blank project by following these steps:

Go to "File" > "New" > "Project..."
In the "New Project" dialog, select the "General" category.
Choose "Blank Project" or a similar option, depending on your Visual Studio configuration.
Assign a name and location to the blank project and click "Create."
Once you have created the blank project, open your project folder in the Solution Explorer.

Copy the .tt file (in your case, t4_solid.tt) to the root folder of the project.

In the Solution Explorer, select the .tt file you just added.

Right-click on the .tt file and select "Properties" from the context menu.

In the .tt file's properties window, set the "Custom Tool" property to "TextTemplatingFileGenerator."

Save the changes to the .tt file properties.

Now, when you make changes to the .tt template and save it, the T4 template will be automatically generated, and the output files will be placed in the location specified in the T4 template configuration.

This approach allows you to use a T4 template within the context of a Visual Studio project and take advantage of automatic code generation from the template. Make sure the T4 template is correctly configured in relation to the output file location and other details according to your needs.
</details>

## IMPORTANT NOTES
**Complexity**: This template is significantly more complex than typical T4 usage. It creates a solution file, project files, and class files with descriptions for each SOLID principle.

**GUIDs for Projects**: The solution file references projects by GUIDs. This example generates new GUIDs for each project. You would need to ensure these GUIDs match those in the generated .csproj files if you are adding them manually.

**Manual Adjustment**s: After running this template, you may need to manually adjust the generated solution and project files to ensure they are correctly structured and reference each other properly.

**Further Customization**: Depending on your exact requirements, you might need to further customize the project file templates (e.g., add specific NuGet packages, set up additional project settings).
