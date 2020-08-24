# C# Godot Platformer
## Godot platformer made using C#

Project is a C# implementation of GDQuest ["Make Your First 2D Game with Godot"](https://www.youtube.com/watch?v=Mc13Z2gboEk).  
- Video one is 100% complete and implemented.  

Continuing to [Video Two](https://www.youtube.com/watch?v=6ziIyx60N6I)  
**Adds:**  
- Coins  
- Portals between levels  


### Notes  
I initially was unable to get the `Player` class to inherit from the `Actor` class becuse the .csproj file was missing the reference to the file containing the parent class. In the future if a class/namespace can not be found confirm the the .csproj file includes entries that follow the below pattern:  
```xml
<ItemGroup>
    <Compile Include="Properties\AssemblyInfo.cs" />
    <Compile Include="Parent.cs" />
    <Compile Include="Child.cs" />
</ItemGroup>
```
