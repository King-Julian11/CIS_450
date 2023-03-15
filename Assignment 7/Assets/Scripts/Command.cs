/* Julian Salgado
 * Command.cs
 * Assignment 7
 * Basic command interface for input commands to implement
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Command
{
    void Execute();
    void Undo();
}
