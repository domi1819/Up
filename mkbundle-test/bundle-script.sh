#!/bin/bash
mkbundle upserver.exe --static --simple -o upserver --machine-config /etc/mono/4.5/machine.config --config /etc/mono/config --library /usr/lib/libmono-native.so --nodeps /usr/lib/mono/4.5/mscorlib.dll /usr/lib/mono/4.5/mscorlib.dll /usr/lib/mono/4.5/System.dll /usr/lib/mono/4.5/Mono.Security.dll /usr/lib/mono/4.5/System.Configuration.dll /usr/lib/mono/4.5/System.Xml.dll /usr/lib/mono/4.5/System.Security.dll /usr/lib/mono/4.5/System.Core.dll
