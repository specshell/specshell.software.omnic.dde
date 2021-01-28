# Omnic DDE #

This repository contains a small application for establishing a DDE connection to Omnic embedded with Omnic specific DDE commands.

These operations will fail if Omnic is not running and this application is not responsible for ensuring that Omnic is running.

Thermo Fisher has supplied an [article](./docs/OMNIC_DDE_Commands_&_Parameters.pdf) for DDE commands supported by Omnic, however it has been found that Omnic supports the *[advanced ATR]* DDE call, which is not documented in the article.

This hints that Omnic might support other DDE commands not mentioned in the article.

### Considerations of making the repository open source ###

It is intended that this repository contains individual DDE commands and *not* sequence of commands.

Hence it can be argued that the repository does not reveal how Specshell specifically operates with Omnic.

However a counter argument to this statement is that we only intend to implement a subset of DDE commands, which are
relevant to our use. Some Omnic supported DDE commands are made specifically for other spectrometers not used by Specshell.

In addition we implement the *[advanced ATR]* DDE command not documented in the article potentially given competitors insight in how we use the spectrometer.

An argument for making the repository open source is to potentially outsource the implementation of Omnic DDE commands not well-known by Specshell.

If we do choose to make the repository Open Source, then a new repository should be made to delete all git history.
