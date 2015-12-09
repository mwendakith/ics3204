
// LorryQueueDlg.cpp : implementation file
//

#include "stdafx.h"
#include "LorryQueue.h"
#include "LorryQueueDlg.h"
#include "afxdialogex.h"
#include <string>
#include <vector>

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// Dialog Data
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// CLorryQueueDlg dialog



CLorryQueueDlg::CLorryQueueDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CLorryQueueDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CLorryQueueDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CLorryQueueDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
    ON_BN_CLICKED(IDOK, &CLorryQueueDlg::OnBnClickedStart)
    ON_WM_TIMER()
END_MESSAGE_MAP()


// CLorryQueueDlg message handlers

BOOL CLorryQueueDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CLorryQueueDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CLorryQueueDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CLorryQueueDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CLorryQueueDlg::OnBnClickedStart() {
    std::ifstream in("times.txt");
    skip_heading(in, ':');
    in >> no_processing_units;
    if (no_processing_units < 1) no_processing_units = 1;
    skip_heading(in, ':');
    in >> processing_min;
    sd.processing_length = Time(0, processing_min);
    for (int i = 0; i < no_processing_units; ++i)
        sd.pro_units.emplace_back(std::make_unique<Processing_unit>());
    // read input file
    skip_heading(in, ':');
    std::string str;
    while (in && !in.eof()) {
        in >> str;
        if (in.fail() || str.length() == 0) break;
        Time arrival_time{ str };
        auto pe = std::make_shared<Arrival>(arrival_time, std::make_shared<Truck>(arrival_time));
        sd.event_queue.emplace(pe);
        pe->set(sd);
    }

    timerID_ = SetTimer(1, 100, 0); // ms
}

void CLorryQueueDlg::OnTimer(UINT_PTR nIDEvent) {
    time_ += mytime::Time(25); //  100ms equivalent to 25s i.e. speedup is 250
    CClientDC dc(this);
    std::wostringstream os{};
    os << L"Time = " << time_.wstr();
    auto msg = os.str();
    dc.TextOut(0, 0, msg.c_str());

    static int count{};

    while (!sd.event_queue.empty() && sd.event_queue.top()->time() < time_) {
        sd.event_queue.top()->run_task(dc);
        sd.event_queue.pop();
    }
}
