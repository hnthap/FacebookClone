---------------
--- PROFILE ---
---------------

CREATE TABLE IF NOT EXISTS Profile (
    ProfileId           INTEGER PRIMARY KEY, 
    FirstName           TEXT NOT NULL,
    LastName            TEXT NOT NULL, 
    Password            TEXT NOT NULL, 
    Email               TEXT NOT NULL,
    BirthDateUnixSecs   INTEGER NOT NULL,
    ImagePath           TEXT,
    IsNotificationOff   INTEGER NOT NULL,
    CONSTRAINT UQ_Profile_Email
        UNIQUE Profile (Email)
);

CREATE TABLE IF NOT EXISTS FriendAccessRight (
    FriendAccessRightId INTEGER PRIMARY KEY,
    Name                TEXT NOT NULL,
    CONSTRAINT UQ_FriendAccessRight_Name
        UNIQUE Profile (Name)
);
-- People you might want to share less with
-- Friends who can only see posts and profile info you make public
-- Your friends, who you can share exclusively with if you want
-- [allow add/remove right]

CREATE TABLE IF NOT EXISTS Friend (
    ProfileId           INTEGER NOT NULL,
    FriendProfileId     INTEGER NOT NULL,
    FriendAccessRightId INTEGER NOT NULL,
    CONSTRAINT PK_Friend
        PRIMARY KEY (ProfileId, FriendProfileId),
    CONSTRAINT FK_Friend_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE,
    CONSTRAINT FK_Friend_Profile_FriendProfileId
        FOREIGN KEY (FriendProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Notification (
    NotificationId      INTEGER PRIMARY KEY,
    Content             TEXT NOT NULL,
    SentAtUnixSecs      INTEGER NOT NULL,
    ProfileId           INTEGER NOT NULL,
    IsRead              INTEGER NOT NULL,
    CONSTRAINT FK_Notification_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Memory (
    MemoryId            INTEGER PRIMARY KEY,
    EstablishedAtUnixSecs INTEGER NOT NULL,
    Content             TEXT NOT NULL,
    ProfileId           INTEGER NOT NULL,
    CONSTRAINT FK_Memory_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Following (
    ProfileId           INTEGER NOT NULL,
    FollowedProfileId   INTEGER NOT NULL,
    CONSTRAINT PK_Following
        PRIMARY KEY (ProfileId, FollowedProfileId),
    CONSTRAINT FK_Following_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE,
    CONSTRAINT FK_Following_Profile_FollowedProfileId
        FOREIGN KEY (FollowedProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Blocking (
    ProfileId           INTEGER NOT NULL,
    BlockedProfileId    INTEGER NOT NULL,
    CONSTRAINT PK_Blocking
        PRIMARY KEY (ProfileId, BlockedProfileId),
    CONSTRAINT FK_Blocking_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE,
    CONSTRAINT FK_Blocking_Profile_BlockedProfileId
        FOREIGN KEY (BlockedProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS Searching (
    ProfileId           INTEGER NOT NULL,
    SearchedAtUnixSecs  INTEGER NOT NULL,
    Prompt              TEXT NOT NULL,
    CONSTRAINT PK_Searching
        PRIMARY KEY (ProfileId, SearchAtUnixSecs)
);

CREATE TABLE IF NOT EXISTS FriendInvitation (
    ProfileId           INTEGER NOT NULL,
    TargetProfileId     INTEGER NOT NULL,
    SentAtUnixSecs      INTEGER NOT NULL,
    CONSTRAINT PK_FriendInvitation
        PRIMARY KEY (ProfileId, TargetProfileId)
);

---------------
--- GROUP ---
---------------

CREATE TABLE IF NOT EXISTS Group (
    GroupId             INTEGER PRIMARY KEY,
    Name                TEXT NOT NULL,
    MemberCount         INTEGER NOT NULL,
    PostCount           INTEGER NOT NULL,
    IsPublic            INTEGER NOT NULL,
    ImagePath           TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS GroupMemberRight (
    GroupMemberRightId  INTEGER PRIMARY KEY,
    Name                TEXT NOT NULL,
    CONSTRAINT UQ_GroupMemberRight_Name
        UNIQUE (Name)
);
-- Administrator
-- Contributor
-- New Member

CREATE TABLE IF NOT EXISTS GroupMember (
    GroupId             INTEGER NOT NULL,
    ProfileId           INTEGER NOT NULL,
    GroupMemberRightId  INTEGER NOT NULL,
    JoinAtUnixSecs      INTEGER NOT NULL,
    CONSTRAINT PK_GroupMember
        PRIMARY KEY (GroupId, ProfileId),
    CONSTRAINT FK_GroupMember_Group_GroupId
        FOREIGN KEY (GroupId) REFERENCES Group(GroupId) ON DELETE CASCADE,
    CONSTRAINT FK_GroupMember_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE,
    CONSTRAINT FK_GroupMember_GroupMemberRight_GroupMemberRightId
        FOREIGN KEY (GroupMemberRightId) REFERENCES GroupMemberRight(GroupMemberRightId) ON DELETE CASCADE
);

---------------
--- PAGE ---
---------------

CREATE TABLE IF NOT EXISTS Page (
    PageId              INTEGER PRIMARY KEY,
    Name                TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS PageMember (
    PageId              INTEGER NOT NULL,
    ProfileId           INTEGER NOT NULL,
    CONSTRAINT PK_PageMember
        PRIMARY KEY (PageId, ProfileId),
    CONSTRAINT FK_PageMember_Page_PageId
        FOREIGN KEY (PageId) REFERENCES Page(PageId) ON DELETE CASCADE,
    CONSTRAINT FK_PageMember_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE
);

---------------
--- POST ---
---------------

CREATE TABLE IF NOT EXISTS Visibility (
    VisibilityId        INTEGER PRIMARY KEY,
    Name                TEXT NOT NULL,
    CONSTRAINT UQ_Visibility_Name
        UNIQUE (Name)
);

CREATE TABLE IF NOT EXISTS Reaction (
    ReactionId          INTEGER PRIMARY KEY,
    Name                TEXT NOT NULL,
    CONSTRAINT UQ_Reaction_Name
        UNIQUE (Name)
);

CREATE TABLE IF NOT EXISTS Post (
    PostId              INTEGER PRIMARY KEY,
    Content             TEXT NOT NULL,
    VisibilityId        INTEGER NOT NULL,
    PostedAtUnixSecs    INTEGER NOT NULL,
    ReactionCount       INTEGER NOT NULL,
    CommentCount        INTEGER NOT NULL, 
    ShareCount          INTEGER NOT NULL,
    Location            TEXT,
    MemoryId            INTEGER,
    CONSTRAINT FK_Post_Visibility_VisibilityId
        FOREIGN KEY (VisibilityId) REFERENCES Visibility(VisibilityId) ON DELETE CASCADE,
    CONSTRAINT FK_Post_Memory_MemoryId
        FOREIGN KEY (MemoryId) REFERENCES Memory(MemoryId) ON DELETE SET NULL
);

CREATE TABLE IF NOT EXISTS ProfilePost (
    ProfileId           INTEGER NOT NULL,
    PostId              INTEGER NOT NULl,
    CONSTRAINT PK_ProfilePost
        PRIMARY KEY (ProfileId, PostId),
    CONSTRAINT FK_ProfilePost_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE,
    CONSTRAINT FK_ProfilePost_Post_PostId
        FOREIGN KEY (PostId) REFERENCES Post(PostId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS GroupPost (
    GroupId             INTEGER NOT NULL,
    ProfileId           INTEGER NOT NULL,
    PostId              INTEGER NOT NULL,
    IsPinned            INTEGER NOT NULL,
    CONSTRAINT PK_GroupPost
        PRIMARY KEY (GroupId, ProfileId, PostId),
    CONSTRAINT FK_GroupPost_Group_GroupId
        FOREIGN KEY (GroupId) REFERENCES Group(GroupId) ON DELETE CASCADE,
    CONSTRAINT FK_GroupPost_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE,
    CONSTRAINT FK_GroupPost_Post_PostId
        FOREIGN KEY (PostId) REFERENCES Post(PostId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS PagePost (
    PageId              INTEGER NOT NULL,
    PostId              INTEGER NOT NULL,
    CONSTRAINT PK_PagePost
        PRIMARY KEY (PageId, PostId),
    CONSTRAINT FK_PagePost_Page_PageId
        FOREIGN KEY (PageId) REFERENCES Page(PageId) ON DELETE CASCADE,
    CONSTRAINT FK_PagePost_Post_PostId
        FOREIGN KEY (PostId) REFERENCES Post(PostId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS PostImage (
    PostId              INTEGER NOT NULL,
    ImageOrder          INTEGER NOT NULL,
    ImagePath           TEXT NOT NULL,
    CONSTRAINT PK_PostImage
        PRIMARY KEY (PostId, ImageOrder),
    CONSTRAINT FK_PostImage_Post_PostId
        FOREIGN KEY (PostId) REFERENCES Post(PostId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS PostVideo (
    PostId              INTEGER NOT NULL,
    VideoOrder          INTEGER NOT NULL,
    VideoPath           TEXT NOT NULL,
    CONSTRAINT PK_PostVideo
        PRIMARY KEY (PostId, VideoOrder),
    CONSTRAINT FK_PostVideo_Post_PostId
        FOREIGN KEY (PostId) REFERENCES Post(PostId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS PostReaction (
    PostId              INTEGER NOT NULL,
    ProfileId           INTEGER NOT NULL,
    ReactionId          INTEGER NOT NULL,
    CONSTRAINT PK_PostReaction
        PRIMARY KEY (PostId, ProfileId),
    CONSTRAINT FK_PostReaction_Post_PostId
        FOREIGN KEY (PostId) REFERENCES Post(PostId) ON DELETE CASCADE,
    CONSTRAINT FK_PostReaction_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE,
    CONSTRAINT FK_PostReaction_Reaction_ReactionId
        FOREIGN KEY (ReactionId) REFERENCES Reaction(ReactionId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS PostComment (
    CommentId           INTEGER PRIMARY KEY, 
    PostId              INTEGER NOT NULL, 
    ProfileId           INTEGER NOT NULL, 
    Content             TEXT NOT NULL, 
    SentAtUnixSecs      INTEGER NOT NULL,
    CONSTRAINT FK_PostComment_Post_PostId
        FOREIGN KEY (PostId) REFERENCES Post(PostId) ON DELETE CASCADE,
    CONSTRAINT FK_PostComment_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS PostCommentReaction (
    CommentId           INTEGER NOT NULL, 
    ProfileId           INTEGER NOT NULL, 
    ReactionId          INTEGER NOT NULL,
    CONSTRAINT PK_PostCommentReaction
        PRIMARY KEY (CommentId, ProfileId),
    CONSTRAINT FK_PostCommentReaction_Comment_CommentId
        FOREIGN KEY (CommentId) REFERENCES Comment(CommentId) ON DELETE CASCADE,
    CONSTRAINT FK_PostCommentReaction_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE,
    CONSTRAINT FK_PostCommentReaction_Reaction_ReactionId
        FOREIGN KEY (ReactionId) REFERENCES Reaction(ReactionId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS PostShare (
    PostId              INTEGER NOT NULL,
    ProfileId           INTEGER NOT NULL, 
    NewPostId           INTEGER NOT NULL,
    CONSTRAINT PK_PostShare
        PRIMARY KEY (PostId, ProfileId, NewPostId),
    CONSTRAINT FK_PostShare_Post_PostId
        FOREIGN KEY (PostId) REFERENCES Post(PostId) ON DELETE CASCADE,
    CONSTRAINT FK_PostShare_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE,
    CONSTRAINT FK_PostShare_Post_NewPostId
        FOREIGN KEY (NewPostId) REFERENCES Post(PostId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS PostSave (
    ProfileId           INTEGER NOT NULL, 
    PostId              INTEGER NOT NULL,
    SavedAtUnixSecs     INTEGER NOT NULL,
    CONSTRAINT PK_PostSave
        PRIMARY KEY (ProfileId, PostId),
    CONSTRAINT FK_PostSave_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE,
    CONSTRAINT FK_PostSave_Post_PostId
        FOREIGN KEY (PostId) REFERENCES Post(PostId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS NotificationOnPost (
    ProfileId           INTEGER NOT NULL,
    PostId              INTEGER NOT NULL,
    CONSTRAINT PK_NotificationOnPost
        PRIMARY KEY (ProfileId, PostId),
    CONSTRAINT FK_NotificationOnPost_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE,
    CONSTRAINT PK_NotificationOnPost_Post_PostId
        FOREIGN KEY (PostId) REFERENCES Post(PostId) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS HideState (
    HideStateId         INTEGER PRIMARY KEY, 
    Name                TEXT NOT NULL,
    CONSTRAINT UQ_HideState_Name
        UNIQUE (Name)
);
-- Ẩn từ nguồn, ẩn từ nhóm

CREATE TABLE IF NOT EXISTS PostHide (
    ProfileId           INTEGER NOT NULL, 
    PostId              INTEGER NOT NULL, 
    BeginAtUnixSecs     INTEGER NOT NULL, 
    EndAtUnixSecs       INTEGER, 
    HideStateId         INTEGER NOT NULL,
    CONSTRAINT PK_PostHide
        PRIMARY KEY (ProfileId, PostId),
    CONSTRAINT FK_PostHide_Profile_ProfileId
        FOREIGN KEY (ProfileId) REFERENCES Profile(ProfileId) ON DELETE CASCADE,
    CONSTRAINT FK_PostHide_Post_PostId
        FOREIGN KEY (PostId) REFERENCES Post(PostId) ON DELETE CASCADE,
    CONSTRAINT FK_PostHide_HideState_HideStateId
        FOREIGN KEY (HideStateId) REFERENCES HideState(HideStateId) ON DELETE CASCADE
);
