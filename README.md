# SOLID Training
Hands on with SOLID principles using [T4 template](https://learn.microsoft.com/en-us/visualstudio/modeling/code-generation-and-t4-text-templates?view=vs-2022) by [Agustin Jose Wawrzyk](https://www.linkedin.com/in/agustinjosew/).

> What is "T4"?
Another name for the Visual Studio text template capabilities described here. The previous version, which was not published, was an abbreviation for "Text Template Transformation".

**What is the benefit of using text templates?**
Typically, you generate multiple code or other files from one model. The model represents the requirements more directly than the generated code. It omits implementation detail and is written in terms of the requirements, rather than the code. When the requirements change - as they usually do - you can update the model more easily and more reliably than the different parts of the program code.

Code generation is therefore a valuable tool from the perspective of agile development methods.


**Running the Template**: Place the .tt file in the root of your solution directory, and run it to generate the solution and project files.

## IMPORTANT NOTES
**Complexity**: This template is significantly more complex than typical T4 usage. It creates a solution file, project files, and class files with descriptions for each SOLID principle.

**GUIDs for Projects**: The solution file references projects by GUIDs. This example generates new GUIDs for each project. You would need to ensure these GUIDs match those in the generated .csproj files if you are adding them manually.

**Manual Adjustment**s: After running this template, you may need to manually adjust the generated solution and project files to ensure they are correctly structured and reference each other properly.

**Further Customization**: Depending on your exact requirements, you might need to further customize the project file templates (e.g., add specific NuGet packages, set up additional project settings).
