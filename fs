#!/bin/bash
find -E . -regex ".*\.m|.*\.py|.*\.conf|.*\.proto|.*\.c|.*\.cc|.*\.cpp|.*\.h|.*\.java|.*\.scala|.*\.el" | xargs grep -i $*
