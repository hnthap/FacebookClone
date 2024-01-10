
INSERT INTO FriendAccessRight (
    FriendAccessRightId, Name
)
VALUES
(1, 'People you might want to share less with'),
(2, 'Friends who can only see posts and profile information you make public'),
(3, 'Friends who you can share exclusively with if you want');

INSERT INTO GroupMemberRight (
    GroupMemberRightId, Name
)
VALUES
(1, 'Administrator'),
(2, 'Contributor'),
(3, 'New member');

INSERT INTO Visibility (
    VisibilityId, Name
)
VALUES
(1, 'Public to all earthlings'),
(2, 'Public to friends'),
(3, 'Private');

INSERT INTO Reaction (
    ReactionId, Name
)
VALUES
(1, 'Like'),
(2, 'Love'),
(3, 'Love so much'),
(4, 'Laugh'),
(5, 'Surprise'),
(6, 'Cry'),
(7, 'Rage');

INSERT INTO HideState (
    HideStateId, Name
)
VALUES
(1, 'Hide from source'),
(2, 'Hide from group');
