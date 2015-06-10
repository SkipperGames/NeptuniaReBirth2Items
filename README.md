# NeptuniaReBirth2Items
Simple trainer/cheater for Neptunia Re;Birth2. Will make dramatic changes to add more editing support, cheats, and hooks. This project will serve (me) as a base for future works.

[Markdown Basics] (https://help.github.com/articles/markdown-basics/)

## Features
* Trainer/cheater that uses [cheatengine-library] (https://github.com/fenix01/cheatengine-library) and ASM to hack game memory. Credits to fenix01 for the library, [Cheat Engine] (http://cheatengine.org/), [Shinkansen] (http://www.cheatengine.org/forum/viewtopic.php?p=5596672&highlight=&sid=feb1433e05054fda693a1cfdacb6e354) for actual cheats
* Get 99 of all items, with the ability to save your existing items from being overwritten and maxed
* Get all level 9 tools, weapons, armor, accessories, star shards, and customized stones for Stella's Dungeon. Certain stone effects can stack (ex. HP lvl+1)

## Usage
*(Keep a working save in case things go weird)*

1. Open Cheat Engine and attach to game process
2. Scan for Items or Stella's Dungeon base address
3. Copy and paste either address to the box provided
4. Depending on what you would like to edit:

- Inventory
  - Check the appropriate boxes for items you would like to have
  - **Save Existing:** Saves your current items from being overwritten and maxed. This feature stacks with **Give Items** so best keep that in mind
  - **Clear Inventory:** Clear your inventory (all 3000 slots)
  - **Give Items:** Gives all items according to the options checked. Be sure to refresh the Item screen in game by exiting or switching tabs

- Stella's Dungeon
  - Click any button; **Tools**, **Weapons**, **Armor**, **Accessories**, and **Star Shards** to get all of those items. Sets those items to Unequipped
  - Use the given combo boxes to build your customized stone; First for the type, next four for its effects. Sets current stone to Unequipped
  - **Clear Stones:** Clear existing stones in your possession. Sets current stone to Unqeuipped
  - **Give Stone:** Get custom-built stone. This will fail if you already have 99. Sets current stone to Unequipped

## TODO
* Improve and optimize code to traditional programming standards and performance
* Integrate Cheat Engine Library to reduce the user's work
* Migrate to C++
* Directly use ASM
