using System;

namespace UIState
{
    public class GlobalUIStateEnums
    {
        public enum UIState { 
            Neutral, // where nothing is happening and anything can happen
            GroupSelecting, // when a rectangle is being dragged across the canvas to select a group of points
            PointEditing, // when a the mouse can click a drag a single point 
            GroupEditing // when a rectangle full of points can be scaled and moved as a group
        }
        public enum UITrigger { 
            NoAction, // actually this is used for for when the mouse is moving around the screen with no mode on and no selection made
            SelectGroupDragged, // when the selection rectangle is dragged out
            PointHovered, // if the mouse is over a point and it can be dragged
            GroupSelected, // if the rectangle selection actually worked
            EditGroupEdgeHovered, // this is for a time maybe in the future to show widget handles and that you are actually able to edit the rectangle at that moment
            EditGroupCentreHovered, // this is for a time maybe in the future to show widget handles when the mouse is in or near the center of a triangle
            EditGroupReleased,  // when the user is done with the GroupEditing mode
            Cancel //basically to go to neutral, and to undo the most recent edit, when correctly applied
        }

        public static string UIStateString(UIState e)
        {
            return e.ToString();
        }

        public static string UITriggerString(UITrigger e)
        {
            return e.ToString();
        }
    }
}