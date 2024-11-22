# dofus3-lang-beta

A fork of the [DDC](https://github.com/Dofus-Batteries-Included/DDC) project to unpack the translations of the Dofus 3 beta client.

Main changes are:
- using `doduda` instead of `cytrus-v6` to download the game much faster
- not running bundle readers
- only exporting *.i18n.json files to GitHub releases

Releases are triggered by the dofusdude update cycle.

This solution and repository will be replaced in the future by a native implementation in `doduda`.