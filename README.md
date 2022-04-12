# OpenRpg.Genres.Tactics

Provides a basic implementation of models/logic for tactics style games.

![](https://i.imgur.com/yaEaAn4.gif)
> This was a prototype using the system in Unity based on the BK9K web game, which uses the tactics lib.

## How To Use It?

Like other OpenRpg genre libraries it will require the `OpenRpg.Genres` library and a couple of other `OpenRpg` related libraries.

As long as you have them just drop it into your project via nuget and off you go.

## The Important Stuff

### Abilities
The abilities object is extended a bit to have the notion of shapes and ranges etc, so you could have a move which hits 1 square in front, hits 2 squares in front, hits a 3x3 square, can hit a 3x3 square up to 10 squares away etc.

> This way you have enough flexibility to be able to express basic/complex attacks which can be applied to the grid to see who would be hit by them etc.

### Areas

Areas are basically the level grids which contain how big the level is (x,y size) and the individual cells that make up the area.

The cells themselves can hold metadata around how height (useful for isometric scenarios) and movement cost as well as ground type.

> This makes it usable for 2d based games or 3d based games

### Units

Units are a slight expansion on the notion of `ICharacter` which contains information about movement range and other values that are unique to the tactics genre.

## Examples

This lib was born from a live stream on making a simple tactics autobattler game which ended up being turned into a unity prototype (shown at top).

The source code for the original web game using Blazor, EcsRx, OpenRpg can be found here:

[https://github.com/grofit/battle-kill-9000](https://github.com/grofit/battle-kill-9000)

> This contains information on both the repo and stream which was done along side it all.



