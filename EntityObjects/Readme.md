# Object Generation From Json

Designed so data can be changed without changing the code. The JSON data is parsed and the data is stored in a dictionary.
The dictionary is then used to create the objects at runtime. Adds the posibility to change data while the code is running.

> Create your json data (1 object per file);
> Put all of the required json data in the same folder(subfolders will not be traversed);
> Create an class(blue print) which has the same name as the Json file(change .json to .cs) for each Json file;
> The parser will load all the Json data in memory, Once the object has to be instantiated the in Json loaded memory will be available as record.

## Features

- Change Json files and reload the new data directly into local storage.
- Units Changable by editing Json files.
- Unit Behaviour interchangeable in Json.

## Installation

Install the dependencies and connect to your c# project of choice.

## License

MIT

**Free Software, Hell Yeah!**
